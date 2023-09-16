using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace CalculatorFine
{
    class Calculator: Icalculator
    {
        public Calculator(decimal debt, DateTime firstDate, DateTime endDate, decimal percent, bool withoutHolidays = false, int daysBeforeFinePeriod = 10, bool withoutHolidaysClaimPeriod = false, bool annual = false)
        {
            this.debt = debt;
            this.firstDate = firstDate;
            this.endDate = endDate;
            this.percent = percent;
            this.withoutHolidays = withoutHolidays;
            this.daysBeforeFinePeriod = daysBeforeFinePeriod;
            this.withoutHolidaysClaimPeriod = withoutHolidaysClaimPeriod;
            this.annual = annual;
        }
        private decimal debt;
        private DateTime firstDate;
        private DateTime endDate;
        private decimal percent;
        private bool withoutHolidays;
        private int daysBeforeFinePeriod;
        private bool withoutHolidaysClaimPeriod;
        private bool annual;
        private int days;

        public decimal CalculateFine()
        {

            DateTime[] holidays = CreateHolidays(firstDate.Year, endDate.Year - firstDate.Year + 1);
            // Если в период ответа на претензию включаются только рабочие дни, нужно вернуть фактическое кол-во календ-ых:
            if (withoutHolidaysClaimPeriod) daysBeforeFinePeriod = CalculateDaysBeforeFinePeriod(firstDate, daysBeforeFinePeriod, holidays);

            // Добавляем время на ответ на претензию, который не входит в срок, к дате подачи претензии:
            firstDate = firstDate.AddDays(daysBeforeFinePeriod);

            // если послед день претензии приходится на выходной или праздничный день он переносится на следующий:
            firstDate = FixDate(firstDate, holidays);

            // Период времени на ответ на претензию еще не прошел:
            if (firstDate >= endDate) return -2;

            // Расчет неустойки без учета выходных и праздничных дней (только рабочие дни)
            if (withoutHolidays) days = CalculateDays(firstDate, endDate, holidays);
            else
            {
                endDate = FixDate(endDate, holidays);
                days = (int)(endDate - firstDate).TotalDays; // с учетом выходных и праздничных
            }

            if (days >= 1180) return -1; // больше срока исковой давности
            else
            {
                decimal result = debt * Convert.ToDecimal(days) * percent / 100;
                if (annual) result = result / 360;
                return result > debt ? debt : result; // размер неустойки не может быть больше размера основного долга
            }
        }

        public string GetDays()
        {
            return Convert.ToString(days);
        }
        private DateTime[] CreateHolidays(int year, int difference = 1)
        {
            // 14 гос. праздников: 1-08.01, 23.02., 08.03, 01.05, 09.05, 12.06, 4.11
            DateTime[] holidays = new DateTime[14 * difference];

            for (int i = 0, j = 0; i < difference; i++)
            {
                for (int k = 1, m = 0; m < holidays.Length / difference; j++, m++)
                {
                    switch (j)
                    {
                        case 8:
                        case 22:
                        case 36:
                            holidays[j] = new DateTime(year, 2, 23);
                            break;
                        case 9:
                        case 23:
                        case 37:
                            holidays[j] = new DateTime(year, 3, 8);
                            break;
                        case 10:
                        case 24:
                        case 38:
                            holidays[j] = new DateTime(year, 5, 1);
                            break;
                        case 11:
                        case 25:
                        case 39:
                            holidays[j] = new DateTime(year, 5, 9);
                            break;
                        case 12:
                        case 26:
                        case 40:
                            holidays[j] = new DateTime(year, 6, 12);
                            break;
                        case 13:
                        case 27:
                        case 41:
                            holidays[j] = new DateTime(year, 11, 4);
                            break;
                        default:
                            holidays[j] = new DateTime(year, 1, k++);
                            break;
                    }
                }
                year++;
            }
            return holidays;
        }
        private int CalculateDays(DateTime startDate, DateTime endDate, DateTime[] holidays)
        {
            endDate = FixDate(endDate, holidays);
            return DifferenceInDays(startDate, endDate, holidays);
        }
        private int CalculateDaysBeforeFinePeriod(DateTime startDate, int daysBeforeFinePeriod, DateTime[] holidays)
        {
            DateTime endDateBeforeFine = firstDate.AddDays(daysBeforeFinePeriod);
            int daysOff = HolidayCount(startDate, endDateBeforeFine, holidays);
            while (daysOff > 0)
            {
                daysBeforeFinePeriod += daysOff;
                DateTime currentStartDate = endDateBeforeFine;
                endDateBeforeFine = endDateBeforeFine.AddDays(daysOff);
                daysOff = HolidayCount(currentStartDate, endDateBeforeFine, holidays);
            }
            DateTime currentEndDateBeforeFine = FixDate(endDateBeforeFine, holidays);
            if (currentEndDateBeforeFine.Day > endDateBeforeFine.Day)
                daysBeforeFinePeriod = currentEndDateBeforeFine.Day - endDateBeforeFine.Day;

            return daysBeforeFinePeriod;
        }
        private DateTime FixDate(DateTime date, DateTime[] holidays)
        {
            if ((date.DayOfWeek == DayOfWeek.Sunday) || FindDateInHolidays(date, holidays))
            {
                date = date.AddDays(1);
                date = FixDate(date, holidays);
            }
            else if (date.DayOfWeek == DayOfWeek.Saturday)
            {
                date = date.AddDays(2);
                date = FixDate(date, holidays);
            }
            return date;
        }
        private int DifferenceInDays(DateTime startDate, DateTime endDate, DateTime[] holidays)
        {
            int difference = (int)(endDate - startDate).TotalDays;
            difference -= HolidayCount(startDate, endDate, holidays);
            return difference;
        }
        private int HolidayCount(DateTime startDate, DateTime endDate, DateTime[] holidays)
        {
            int holidayCount = DaysOffInRange(startDate, endDate);
            foreach (DateTime holiday in holidays)
            {
                if (HolidayInRange(startDate, endDate, holiday))
                {
                    holidayCount++;
                    if (HolidaysCoincideWithDaysOff(holiday)) holidayCount--;
                }

            }
            return holidayCount;
        }
        private int DaysOffInRange(DateTime startDate, DateTime endDate)
        {
            DateTime current = startDate;
            int result = endDate.Year - startDate.Year;
            int daysOff = 0;
            if (result > 0)// период больше года
            {
                if (result > 1)  // период больше одного года
                {
                    daysOff = 104 * (result - 1); // в среднем 104 вых дня в году (редко 105, еще реже 106)
                    current.AddYears(result - 1);
                }
                result = endDate.Month - startDate.Month; // проверка действительно ли период больше года через месяцы
                if (result > 0)
                {
                    daysOff += 104;
                    current = current.AddYears(1);
                }
                else result = 12 - startDate.Month + endDate.Month;
            }
            else result = endDate.Month - startDate.Month;

            int addDays = CountDaysOffInMonthsDifference(ref current, endDate, result);
            if (addDays > 0) daysOff += addDays;

            daysOff += CountDaysOff(current, endDate);

            return daysOff;
        }
        private int CountDaysOff(DateTime startDate, DateTime endDate)
        {
            int count = 0;
            int daysLong = 0;

            if (startDate.Month == endDate.Month)
            {
                daysLong += endDate.Day - startDate.Day;
            }
            else
            {
                for (int i = startDate.Month; i <= endDate.Month; i++)
                {
                    daysLong += DateTime.DaysInMonth(startDate.Year, i);
                    if (i == startDate.Month) daysLong -= startDate.Day;
                    else if (i == endDate.Month)
                        daysLong -= (DateTime.DaysInMonth(startDate.Year, i) - endDate.Day);
                }
            }

            daysLong -= StepFirstDateCount(startDate, ref count);
            daysLong -= StepLastDateCount(endDate, ref count);

            count += (daysLong / 7) * 2;

            return count;
        }
        private int StepFirstDateCount(DateTime day, ref int days)
        {
            switch (day.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    days += 2;
                    return 6;
                case DayOfWeek.Tuesday:
                    days += 2;
                    return 5;
                case DayOfWeek.Wednesday:
                    days += 2;
                    return 4;
                case DayOfWeek.Thursday:
                    days += 2;
                    return 3;
                case DayOfWeek.Friday:
                    days += 2;
                    return 2;
                case DayOfWeek.Saturday:
                    days += 1;
                    return 1;
                default:
                    return 0;
            }
        }
        private int StepLastDateCount(DateTime day, ref int days)
        {
            switch (day.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    days += 2;
                    return 7;
                case DayOfWeek.Saturday:
                    days += 1;
                    return 6;
                case DayOfWeek.Tuesday:
                    return 2;
                case DayOfWeek.Wednesday:
                    return 3;
                case DayOfWeek.Thursday:
                    return 4;
                case DayOfWeek.Friday:
                    return 5;
                default:
                    return 0;
            }
        }
        private int CountDaysOffInMonthsDifference(ref DateTime startDate, DateTime endDate, int difference)
        {
            if (difference > 9)
            {
                startDate = startDate.AddMonths(9);
                return 78;
            }
            else if (difference > 6)
            {
                startDate = startDate.AddMonths(6);
                return 52;
            }
            else if (difference > 3)
            {
                startDate = startDate.AddMonths(3);
                return 26;
            }
            return 0;
        }
        private bool HolidaysCoincideWithDaysOff(DateTime holiday)
        {
            return (holiday.DayOfWeek == DayOfWeek.Saturday || holiday.DayOfWeek == DayOfWeek.Sunday);
        }
        private bool HolidayInRange(DateTime startDate, DateTime endDate, DateTime holiday)
        {
            return (holiday.Date > startDate && holiday < endDate);
        }
        private bool FindDateInHolidays(DateTime date, DateTime[] holidays)
        {
            foreach (var holiday in holidays)
            {
                if (holiday.CompareTo(date) == 0) return true;
            }
            return false;
        }
    }
}
