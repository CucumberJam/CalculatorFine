namespace CalculatorFine
{
    partial class frmMainCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDebt = new MaskedTextBox();
            txtDateFirst = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            btnExit = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            btnAnnual = new RadioButton();
            btnEveryDay = new RadioButton();
            txtPercent = new NumericUpDown();
            groupBox2 = new GroupBox();
            btnWithoutHolidaysClaimPeriod = new RadioButton();
            btnWithHolidaysClaimPeriod = new RadioButton();
            txtBeforeFinePeriod = new NumericUpDown();
            label5 = new Label();
            groupBox3 = new GroupBox();
            btnWithoutHolidays = new RadioButton();
            btnWithHolidays = new RadioButton();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtDateLast = new DateTimePicker();
            btnCalculate = new Button();
            btnClear = new Button();
            refCalculFineCustomer = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPercent).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtBeforeFinePeriod).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtDebt
            // 
            txtDebt.BackColor = Color.White;
            txtDebt.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDebt.ForeColor = Color.FromArgb(164, 165, 169);
            txtDebt.Location = new Point(153, 97);
            txtDebt.Mask = "$999999.99";
            txtDebt.Name = "txtDebt";
            txtDebt.Size = new Size(100, 25);
            txtDebt.TabIndex = 0;
            // 
            // txtDateFirst
            // 
            txtDateFirst.CalendarFont = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtDateFirst.CalendarForeColor = Color.Gray;
            txtDateFirst.CalendarTitleForeColor = Color.Purple;
            txtDateFirst.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateFirst.Format = DateTimePickerFormat.Short;
            txtDateFirst.Location = new Point(249, 430);
            txtDateFirst.MaxDate = new DateTime(2045, 12, 31, 0, 0, 0, 0);
            txtDateFirst.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            txtDateFirst.Name = "txtDateFirst";
            txtDateFirst.Size = new Size(120, 25);
            txtDateFirst.TabIndex = 1;
            txtDateFirst.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Dubai", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(95, 9);
            label1.Name = "label1";
            label1.Size = new Size(274, 54);
            label1.TabIndex = 2;
            label1.Text = "Калькулятор";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Dubai", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(86, 54);
            label2.Name = "label2";
            label2.Size = new Size(306, 36);
            label2.TabIndex = 2;
            label2.Text = "для расчета неустойки";
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(164, 165, 169);
            btnExit.Location = new Point(421, 18);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(21, 21);
            btnExit.TabIndex = 3;
            btnExit.Text = "Х";
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(164, 165, 169);
            label3.Location = new Point(31, 100);
            label3.Name = "label3";
            label3.Size = new Size(107, 17);
            label3.TabIndex = 3;
            label3.Text = "Сумма долга:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(164, 165, 169);
            label4.Location = new Point(31, 130);
            label4.Name = "label4";
            label4.Size = new Size(152, 17);
            label4.TabIndex = 3;
            label4.Text = "Размер процентов:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAnnual);
            groupBox1.Controls.Add(btnEveryDay);
            groupBox1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(164, 165, 169);
            groupBox1.Location = new Point(25, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 61);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Процент неустойки рассчитывается:";
            // 
            // btnAnnual
            // 
            btnAnnual.AutoSize = true;
            btnAnnual.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnnual.Location = new Point(240, 24);
            btnAnnual.Name = "btnAnnual";
            btnAnnual.Size = new Size(81, 19);
            btnAnnual.TabIndex = 0;
            btnAnnual.Text = "Годовой";
            btnAnnual.UseVisualStyleBackColor = true;
            // 
            // btnEveryDay
            // 
            btnEveryDay.AutoSize = true;
            btnEveryDay.Checked = true;
            btnEveryDay.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEveryDay.Location = new Point(6, 24);
            btnEveryDay.Name = "btnEveryDay";
            btnEveryDay.Size = new Size(203, 19);
            btnEveryDay.TabIndex = 0;
            btnEveryDay.TabStop = true;
            btnEveryDay.Text = "За каждый день просрочки";
            btnEveryDay.UseVisualStyleBackColor = true;
            // 
            // txtPercent
            // 
            txtPercent.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPercent.ForeColor = Color.FromArgb(164, 164, 169);
            txtPercent.Location = new Point(249, 130);
            txtPercent.Name = "txtPercent";
            txtPercent.Size = new Size(120, 25);
            txtPercent.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnWithoutHolidaysClaimPeriod);
            groupBox2.Controls.Add(btnWithHolidaysClaimPeriod);
            groupBox2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.FromArgb(164, 165, 169);
            groupBox2.Location = new Point(31, 266);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(398, 75);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "В период ответа на претензию включаются:";
            // 
            // btnWithoutHolidaysClaimPeriod
            // 
            btnWithoutHolidaysClaimPeriod.AutoSize = true;
            btnWithoutHolidaysClaimPeriod.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnWithoutHolidaysClaimPeriod.Location = new Point(6, 49);
            btnWithoutHolidaysClaimPeriod.Name = "btnWithoutHolidaysClaimPeriod";
            btnWithoutHolidaysClaimPeriod.Size = new Size(303, 19);
            btnWithoutHolidaysClaimPeriod.TabIndex = 0;
            btnWithoutHolidaysClaimPeriod.Text = "Рабочие дни (без выходных и праздников)";
            btnWithoutHolidaysClaimPeriod.UseVisualStyleBackColor = true;
            // 
            // btnWithHolidaysClaimPeriod
            // 
            btnWithHolidaysClaimPeriod.AutoSize = true;
            btnWithHolidaysClaimPeriod.Checked = true;
            btnWithHolidaysClaimPeriod.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnWithHolidaysClaimPeriod.Location = new Point(6, 24);
            btnWithHolidaysClaimPeriod.Name = "btnWithHolidaysClaimPeriod";
            btnWithHolidaysClaimPeriod.Size = new Size(395, 19);
            btnWithHolidaysClaimPeriod.TabIndex = 0;
            btnWithHolidaysClaimPeriod.TabStop = true;
            btnWithHolidaysClaimPeriod.Text = "Календарные дни (вместе с выходными и праздниками)";
            btnWithHolidaysClaimPeriod.UseVisualStyleBackColor = true;
            // 
            // txtBeforeFinePeriod
            // 
            txtBeforeFinePeriod.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBeforeFinePeriod.ForeColor = Color.FromArgb(164, 164, 169);
            txtBeforeFinePeriod.Location = new Point(249, 235);
            txtBeforeFinePeriod.Maximum = new decimal(new int[] { 45, 0, 0, 0 });
            txtBeforeFinePeriod.Name = "txtBeforeFinePeriod";
            txtBeforeFinePeriod.Size = new Size(120, 25);
            txtBeforeFinePeriod.TabIndex = 7;
            txtBeforeFinePeriod.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(164, 165, 169);
            label5.Location = new Point(31, 237);
            label5.Name = "label5";
            label5.Size = new Size(212, 17);
            label5.TabIndex = 6;
            label5.Text = "Срок ответа на претензию:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnWithoutHolidays);
            groupBox3.Controls.Add(btnWithHolidays);
            groupBox3.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.FromArgb(164, 165, 169);
            groupBox3.Location = new Point(31, 347);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(398, 77);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "В период неустойки включаются:";
            // 
            // btnWithoutHolidays
            // 
            btnWithoutHolidays.AutoSize = true;
            btnWithoutHolidays.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnWithoutHolidays.Location = new Point(6, 49);
            btnWithoutHolidays.Name = "btnWithoutHolidays";
            btnWithoutHolidays.Size = new Size(303, 19);
            btnWithoutHolidays.TabIndex = 0;
            btnWithoutHolidays.Text = "Рабочие дни (без выходных и праздников)";
            btnWithoutHolidays.UseVisualStyleBackColor = true;
            // 
            // btnWithHolidays
            // 
            btnWithHolidays.AutoSize = true;
            btnWithHolidays.Checked = true;
            btnWithHolidays.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnWithHolidays.Location = new Point(6, 24);
            btnWithHolidays.Name = "btnWithHolidays";
            btnWithHolidays.Size = new Size(395, 19);
            btnWithHolidays.TabIndex = 0;
            btnWithHolidays.TabStop = true;
            btnWithHolidays.Text = "Календарные дни (вместе с выходными и праздниками)";
            btnWithHolidays.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(164, 165, 169);
            label6.Location = new Point(31, 605);
            label6.Name = "label6";
            label6.Size = new Size(392, 15);
            label6.TabIndex = 6;
            label6.Text = "Нужно расчитать неустойки по потребительским спорам?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(164, 165, 169);
            label7.Location = new Point(31, 465);
            label7.Name = "label7";
            label7.Size = new Size(127, 17);
            label7.TabIndex = 6;
            label7.Text = "Дата окончания";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(164, 165, 169);
            label8.Location = new Point(31, 482);
            label8.Name = "label8";
            label8.Size = new Size(155, 17);
            label8.TabIndex = 6;
            label8.Text = "расчета неустойка:";
            // 
            // txtDateLast
            // 
            txtDateLast.CalendarFont = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtDateLast.CalendarForeColor = Color.Gray;
            txtDateLast.CalendarTitleForeColor = Color.Purple;
            txtDateLast.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateLast.Format = DateTimePickerFormat.Short;
            txtDateLast.Location = new Point(249, 469);
            txtDateLast.MaxDate = new DateTime(2045, 12, 31, 0, 0, 0, 0);
            txtDateLast.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            txtDateLast.Name = "txtDateLast";
            txtDateLast.Size = new Size(120, 25);
            txtDateLast.TabIndex = 1;
            txtDateLast.Value = new DateTime(2023, 9, 14, 0, 0, 0, 0);
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(116, 86, 174);
            btnCalculate.FlatStyle = FlatStyle.Popup;
            btnCalculate.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(124, 511);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(216, 35);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "РАССЧИТАТЬ";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.FromArgb(116, 86, 174);
            btnClear.Location = new Point(124, 552);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(216, 35);
            btnClear.TabIndex = 8;
            btnClear.Text = "ОЧИСТИТЬ";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // refCalculFineCustomer
            // 
            refCalculFineCustomer.AutoSize = true;
            refCalculFineCustomer.Font = new Font("Nirmala UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            refCalculFineCustomer.ForeColor = Color.FromArgb(116, 86, 174);
            refCalculFineCustomer.Location = new Point(79, 630);
            refCalculFineCustomer.Name = "refCalculFineCustomer";
            refCalculFineCustomer.Size = new Size(290, 15);
            refCalculFineCustomer.TabIndex = 6;
            refCalculFineCustomer.Text = "Калькулятор неустойки для потребителей";
            refCalculFineCustomer.Click += refCalculFineCustomer_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(164, 165, 169);
            label9.Location = new Point(31, 438);
            label9.Name = "label9";
            label9.Size = new Size(190, 17);
            label9.TabIndex = 6;
            label9.Text = "Дата подачи претензии:";
            // 
            // frmMainCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(452, 673);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtBeforeFinePeriod);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(refCalculFineCustomer);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(txtPercent);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnExit);
            Controls.Add(label2);
            Controls.Add(txtDateLast);
            Controls.Add(label1);
            Controls.Add(txtDateFirst);
            Controls.Add(txtDebt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMainCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPercent).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtBeforeFinePeriod).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtDebt;
        private DateTimePicker txtDateFirst;
        private Label label1;
        private Label label2;
        private Label btnExit;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton btnAnnual;
        private RadioButton btnEveryDay;
        private NumericUpDown txtPercent;
        private GroupBox groupBox2;
        private RadioButton btnWithoutHolidaysClaimPeriod;
        private RadioButton btnWithHolidaysClaimPeriod;
        private NumericUpDown txtBeforeFinePeriod;
        private Label label5;
        private GroupBox groupBox3;
        private RadioButton btnWithoutHolidays;
        private RadioButton btnWithHolidays;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker txtDateLast;
        private Button btnCalculate;
        private Button btnClear;
        private Label refCalculFineCustomer;
        private Label label9;
    }
}