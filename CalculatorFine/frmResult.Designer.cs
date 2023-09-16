namespace CalculatorFine
{
    partial class frmResult
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
            btnExit = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTotalSum = new Label();
            label3 = new Label();
            label9 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtDebt = new Label();
            label7 = new Label();
            txtPercent = new Label();
            label6 = new Label();
            txtDays = new Label();
            label8 = new Label();
            refCalculFineCustom = new Label();
            label10 = new Label();
            refCalculFineUsual = new Label();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(164, 165, 169);
            btnExit.Location = new Point(403, 9);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(21, 21);
            btnExit.TabIndex = 17;
            btnExit.Text = "Х";
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Dubai", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(52, 360);
            label2.Name = "label2";
            label2.Size = new Size(114, 36);
            label2.TabIndex = 16;
            label2.Text = "ИТОГО:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Dubai", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(29, 88);
            label1.Name = "label1";
            label1.Size = new Size(385, 54);
            label1.TabIndex = 15;
            label1.Text = "Результат расчета";
            // 
            // txtTotalSum
            // 
            txtTotalSum.AutoSize = true;
            txtTotalSum.Font = new Font("Dubai", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            txtTotalSum.ForeColor = Color.FromArgb(116, 86, 174);
            txtTotalSum.Location = new Point(172, 360);
            txtTotalSum.Name = "txtTotalSum";
            txtTotalSum.Size = new Size(110, 36);
            txtTotalSum.TabIndex = 16;
            txtTotalSum.Text = "ИТОГО";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Dubai", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(116, 86, 174);
            label3.Location = new Point(277, 360);
            label3.Name = "label3";
            label3.Size = new Size(107, 36);
            label3.TabIndex = 16;
            label3.Text = "рублей";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(164, 165, 169);
            label9.Location = new Point(52, 193);
            label9.Name = "label9";
            label9.Size = new Size(107, 17);
            label9.TabIndex = 30;
            label9.Text = "Сумма долга:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(164, 165, 169);
            label4.Location = new Point(52, 232);
            label4.Name = "label4";
            label4.Size = new Size(152, 17);
            label4.TabIndex = 30;
            label4.Text = "Размер процентов:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(164, 165, 169);
            label5.Location = new Point(52, 273);
            label5.Name = "label5";
            label5.Size = new Size(223, 17);
            label5.TabIndex = 30;
            label5.Text = "Количество дней просрочки:";
            // 
            // txtDebt
            // 
            txtDebt.AutoSize = true;
            txtDebt.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtDebt.ForeColor = Color.FromArgb(164, 165, 169);
            txtDebt.Location = new Point(165, 193);
            txtDebt.Name = "txtDebt";
            txtDebt.Size = new Size(56, 17);
            txtDebt.TabIndex = 30;
            txtDebt.Text = "Сумма";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(164, 165, 169);
            label7.Location = new Point(227, 193);
            label7.Name = "label7";
            label7.Size = new Size(62, 17);
            label7.TabIndex = 30;
            label7.Text = "рублей";
            // 
            // txtPercent
            // 
            txtPercent.AutoSize = true;
            txtPercent.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtPercent.ForeColor = Color.FromArgb(164, 165, 169);
            txtPercent.Location = new Point(210, 232);
            txtPercent.Name = "txtPercent";
            txtPercent.Size = new Size(46, 17);
            txtPercent.TabIndex = 30;
            txtPercent.Text = "Разм";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(164, 165, 169);
            label6.Location = new Point(262, 232);
            label6.Name = "label6";
            label6.Size = new Size(19, 17);
            label6.TabIndex = 30;
            label6.Text = "%";
            // 
            // txtDays
            // 
            txtDays.AutoSize = true;
            txtDays.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtDays.ForeColor = Color.FromArgb(164, 165, 169);
            txtDays.Location = new Point(281, 273);
            txtDays.Name = "txtDays";
            txtDays.Size = new Size(35, 17);
            txtDays.TabIndex = 30;
            txtDays.Text = "Кол";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(164, 165, 169);
            label8.Location = new Point(322, 273);
            label8.Name = "label8";
            label8.Size = new Size(44, 17);
            label8.TabIndex = 30;
            label8.Text = "дней";
            // 
            // refCalculFineCustom
            // 
            refCalculFineCustom.AutoSize = true;
            refCalculFineCustom.Font = new Font("Nirmala UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            refCalculFineCustom.ForeColor = Color.FromArgb(116, 86, 174);
            refCalculFineCustom.Location = new Point(72, 552);
            refCalculFineCustom.Name = "refCalculFineCustom";
            refCalculFineCustom.Size = new Size(290, 15);
            refCalculFineCustom.TabIndex = 31;
            refCalculFineCustom.Text = "Калькулятор неустойки для потребителей";
            refCalculFineCustom.Click += refCalculFineCustom_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(164, 165, 169);
            label10.Location = new Point(112, 523);
            label10.Name = "label10";
            label10.Size = new Size(206, 15);
            label10.TabIndex = 32;
            label10.Text = "Нужен перерасчёт неустойки?";
            // 
            // refCalculFineUsual
            // 
            refCalculFineUsual.AutoSize = true;
            refCalculFineUsual.Font = new Font("Nirmala UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            refCalculFineUsual.ForeColor = Color.FromArgb(116, 86, 174);
            refCalculFineUsual.Location = new Point(89, 586);
            refCalculFineUsual.Name = "refCalculFineUsual";
            refCalculFineUsual.Size = new Size(273, 15);
            refCalculFineUsual.TabIndex = 31;
            refCalculFineUsual.Text = "Калькулятор для стандартного расчета";
            refCalculFineUsual.Click += refCalculFineUsual_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(29, 175);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 138);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            // 
            // frmResult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(436, 634);
            Controls.Add(refCalculFineUsual);
            Controls.Add(refCalculFineCustom);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(txtDays);
            Controls.Add(txtPercent);
            Controls.Add(txtDebt);
            Controls.Add(label9);
            Controls.Add(btnExit);
            Controls.Add(label3);
            Controls.Add(txtTotalSum);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmResult";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmResult";
            Load += frmResult_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnExit;
        private Label label2;
        private Label label1;
        private Label txtTotalSum;
        private Label label3;
        private Label label9;
        private Label label4;
        private Label label5;
        private Label txtDebt;
        private Label label7;
        private Label txtPercent;
        private Label label6;
        private Label txtDays;
        private Label label8;
        private Label refCalculFineCustom;
        private Label label10;
        private Label refCalculFineUsual;
        private GroupBox groupBox1;
    }
}