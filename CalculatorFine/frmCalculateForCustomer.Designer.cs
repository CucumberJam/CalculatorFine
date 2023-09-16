namespace CalculatorFine
{
    partial class frmCalculateForCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClear = new Button();
            btnCalculate = new Button();
            label8 = new Label();
            label7 = new Label();
            refCalculFineUsual = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            label14 = new Label();
            label11 = new Label();
            FineThreePercent = new RadioButton();
            btnFineOnePercent = new RadioButton();
            btnFineHalfPercent = new RadioButton();
            label5 = new Label();
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnExit = new Label();
            label2 = new Label();
            txtDateLast = new DateTimePicker();
            label1 = new Label();
            txtDateFirst = new DateTimePicker();
            txtDebt = new MaskedTextBox();
            label9 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.FromArgb(116, 86, 174);
            btnClear.Location = new Point(114, 532);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(216, 35);
            btnClear.TabIndex = 28;
            btnClear.Text = "ОЧИСТИТЬ";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(116, 86, 174);
            btnCalculate.FlatStyle = FlatStyle.Popup;
            btnCalculate.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(114, 491);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(216, 35);
            btnCalculate.TabIndex = 27;
            btnCalculate.Text = "РАССЧИТАТЬ";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(164, 165, 169);
            label8.Location = new Point(22, 209);
            label8.Name = "label8";
            label8.Size = new Size(155, 17);
            label8.TabIndex = 25;
            label8.Text = "расчета неустойка:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(164, 165, 169);
            label7.Location = new Point(22, 190);
            label7.Name = "label7";
            label7.Size = new Size(127, 17);
            label7.TabIndex = 24;
            label7.Text = "Дата окончания";
            // 
            // refCalculFineUsual
            // 
            refCalculFineUsual.AutoSize = true;
            refCalculFineUsual.Font = new Font("Nirmala UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            refCalculFineUsual.ForeColor = Color.FromArgb(116, 86, 174);
            refCalculFineUsual.Location = new Point(137, 619);
            refCalculFineUsual.Name = "refCalculFineUsual";
            refCalculFineUsual.Size = new Size(164, 15);
            refCalculFineUsual.TabIndex = 23;
            refCalculFineUsual.Text = "Калькулятор неустойки";
            refCalculFineUsual.Click += refCalculFineUsual_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(164, 165, 169);
            label6.Location = new Point(26, 591);
            label6.Name = "label6";
            label6.Size = new Size(392, 15);
            label6.TabIndex = 22;
            label6.Text = "Нужно расчитать неустойки по потребительским спорам?";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(FineThreePercent);
            groupBox2.Controls.Add(btnFineOnePercent);
            groupBox2.Controls.Add(btnFineHalfPercent);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.FromArgb(164, 165, 169);
            groupBox2.Location = new Point(20, 256);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(398, 215);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Выберите категорию:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(192, 0, 0);
            label14.Location = new Point(360, 182);
            label14.Name = "label14";
            label14.Size = new Size(37, 21);
            label14.TabIndex = 17;
            label14.Text = "3 %";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(192, 0, 0);
            label11.Location = new Point(360, 98);
            label11.Name = "label11";
            label11.Size = new Size(37, 21);
            label11.TabIndex = 16;
            label11.Text = "1 %";
            // 
            // FineThreePercent
            // 
            FineThreePercent.AutoSize = true;
            FineThreePercent.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FineThreePercent.Location = new Point(16, 141);
            FineThreePercent.Name = "FineThreePercent";
            FineThreePercent.Size = new Size(350, 19);
            FineThreePercent.TabIndex = 0;
            FineThreePercent.Text = "За просрочку выполнения работ и при просрочке";
            FineThreePercent.UseVisualStyleBackColor = true;
            // 
            // btnFineOnePercent
            // 
            btnFineOnePercent.AutoSize = true;
            btnFineOnePercent.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFineOnePercent.Location = new Point(16, 75);
            btnFineOnePercent.Name = "btnFineOnePercent";
            btnFineOnePercent.Size = new Size(335, 19);
            btnFineOnePercent.TabIndex = 0;
            btnFineOnePercent.Text = "За просрочку удовлетворения требований при";
            btnFineOnePercent.UseVisualStyleBackColor = true;
            // 
            // btnFineHalfPercent
            // 
            btnFineHalfPercent.AutoSize = true;
            btnFineHalfPercent.Checked = true;
            btnFineHalfPercent.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFineHalfPercent.Location = new Point(16, 24);
            btnFineHalfPercent.Name = "btnFineHalfPercent";
            btnFineHalfPercent.Size = new Size(381, 19);
            btnFineHalfPercent.TabIndex = 0;
            btnFineHalfPercent.TabStop = true;
            btnFineHalfPercent.Text = "За просрочку передачи предварительно оплаченного";
            btnFineHalfPercent.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(347, 41);
            label5.Name = "label5";
            label5.Size = new Size(50, 21);
            label5.TabIndex = 15;
            label5.Text = "0,5 %";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(164, 165, 169);
            label13.Location = new Point(94, 104);
            label13.Name = "label13";
            label13.Size = new Size(272, 15);
            label13.TabIndex = 15;
            label13.Text = "при продаже некачественного товара - ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(164, 165, 169);
            label12.Location = new Point(218, 187);
            label12.Name = "label12";
            label12.Size = new Size(143, 15);
            label12.TabIndex = 15;
            label12.Text = "выполнения работ - ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(164, 165, 169);
            label10.Location = new Point(48, 163);
            label10.Name = "label10";
            label10.Size = new Size(318, 15);
            label10.TabIndex = 15;
            label10.Text = "удовлетворения требований потребителя при";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(164, 165, 169);
            label4.Location = new Point(285, 46);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 15;
            label4.Text = "товара - ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(164, 165, 169);
            label3.Location = new Point(22, 107);
            label3.Name = "label3";
            label3.Size = new Size(107, 17);
            label3.TabIndex = 15;
            label3.Text = "Сумма долга:";
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(164, 165, 169);
            btnExit.Location = new Point(410, 19);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(21, 21);
            btnExit.TabIndex = 14;
            btnExit.Text = "Х";
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Dubai", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(77, 54);
            label2.Name = "label2";
            label2.Size = new Size(306, 36);
            label2.TabIndex = 13;
            label2.Text = "для расчета неустойки";
            // 
            // txtDateLast
            // 
            txtDateLast.CalendarFont = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtDateLast.CalendarForeColor = Color.Gray;
            txtDateLast.CalendarTitleForeColor = Color.Purple;
            txtDateLast.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateLast.Format = DateTimePickerFormat.Short;
            txtDateLast.Location = new Point(240, 201);
            txtDateLast.MaxDate = new DateTime(2045, 12, 31, 0, 0, 0, 0);
            txtDateLast.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            txtDateLast.Name = "txtDateLast";
            txtDateLast.Size = new Size(120, 25);
            txtDateLast.TabIndex = 10;
            txtDateLast.Value = new DateTime(2023, 9, 14, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Dubai", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(86, 9);
            label1.Name = "label1";
            label1.Size = new Size(274, 54);
            label1.TabIndex = 12;
            label1.Text = "Калькулятор";
            // 
            // txtDateFirst
            // 
            txtDateFirst.CalendarFont = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtDateFirst.CalendarForeColor = Color.Gray;
            txtDateFirst.CalendarTitleForeColor = Color.Purple;
            txtDateFirst.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateFirst.Format = DateTimePickerFormat.Short;
            txtDateFirst.Location = new Point(236, 146);
            txtDateFirst.MaxDate = new DateTime(2045, 12, 31, 0, 0, 0, 0);
            txtDateFirst.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            txtDateFirst.Name = "txtDateFirst";
            txtDateFirst.Size = new Size(120, 25);
            txtDateFirst.TabIndex = 11;
            txtDateFirst.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // txtDebt
            // 
            txtDebt.BackColor = Color.White;
            txtDebt.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDebt.ForeColor = Color.FromArgb(164, 165, 169);
            txtDebt.Location = new Point(147, 104);
            txtDebt.Mask = "$999999.99";
            txtDebt.Name = "txtDebt";
            txtDebt.Size = new Size(100, 25);
            txtDebt.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(164, 165, 169);
            label9.Location = new Point(20, 152);
            label9.Name = "label9";
            label9.Size = new Size(190, 17);
            label9.TabIndex = 29;
            label9.Text = "Дата подачи претензии:";
            // 
            // frmCalculateForCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(452, 673);
            Controls.Add(label9);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(refCalculFineUsual);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            Controls.Add(btnExit);
            Controls.Add(label2);
            Controls.Add(txtDateLast);
            Controls.Add(label1);
            Controls.Add(txtDateFirst);
            Controls.Add(txtDebt);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCalculateForCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ы";
            Load += frmCalculateForCustomer_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnCalculate;
        private NumericUpDown txtBeforeFinePeriod;
        private Label label8;
        private Label label7;
        private Label refCalculFineUsual;
        private Label label6;
        private GroupBox groupBox3;
        private RadioButton btnWithoutHolidays;
        private RadioButton btnWithHolidays;
        private GroupBox groupBox2;
        private RadioButton btnFineOnePercent;
        private RadioButton btnFineHalfPercent;
        private NumericUpDown txtPercent;
        private GroupBox groupBox1;
        private RadioButton btnAnnual;
        private RadioButton btnEveryDay;
        private Label label3;
        private Label btnExit;
        private Label label2;
        private DateTimePicker txtDateLast;
        private Label label1;
        private DateTimePicker txtDateFirst;
        private MaskedTextBox txtDebt;
        private RadioButton FineThreePercent;
        private Label label9;
        private Label label5;
        private Label label4;
        private Label label11;
        private Label label10;
        private Label label14;
        private Label label13;
        private Label label12;
    }
}