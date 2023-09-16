namespace CalculatorFine
{
    partial class frmSplashScreen
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            label1 = new Label();
            progressBar = new ProgressBar();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            progressPercent = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Dubai", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(76, 77);
            label2.Name = "label2";
            label2.Size = new Size(306, 36);
            label2.TabIndex = 15;
            label2.Text = "для расчета неустойки";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Dubai", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(85, 32);
            label1.Name = "label1";
            label1.Size = new Size(274, 54);
            label1.TabIndex = 14;
            label1.Text = "Калькулятор";
            // 
            // progressBar
            // 
            progressBar.Cursor = Cursors.WaitCursor;
            progressBar.ForeColor = Color.FromArgb(116, 86, 174);
            progressBar.Location = new Point(62, 227);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(297, 23);
            progressBar.Step = 6;
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Dubai", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(116, 86, 174);
            label3.Location = new Point(139, 285);
            label3.Name = "label3";
            label3.Size = new Size(143, 36);
            label3.TabIndex = 15;
            label3.Text = "Загрузка...";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // progressPercent
            // 
            progressPercent.AutoSize = true;
            progressPercent.Font = new Font("Dubai", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            progressPercent.ForeColor = Color.FromArgb(116, 86, 174);
            progressPercent.Location = new Point(194, 178);
            progressPercent.Name = "progressPercent";
            progressPercent.Size = new Size(27, 36);
            progressPercent.TabIndex = 15;
            progressPercent.Text = "...";
            // 
            // frmSplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(436, 634);
            Controls.Add(progressBar);
            Controls.Add(progressPercent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSplashScreen";
            Load += frmSplashScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private ProgressBar progressBar;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private Label progressPercent;
    }
}