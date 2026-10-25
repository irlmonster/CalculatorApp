namespace Calculator_App
{
    partial class Application
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
            resultBox = new TextBox();
            nmbBtn7 = new Button();
            nmbBtn8 = new Button();
            nmbBtn9 = new Button();
            nmbBtn4 = new Button();
            nmbBtn5 = new Button();
            nmbBtn6 = new Button();
            nmbBtn1 = new Button();
            nmbBtn2 = new Button();
            nmbBtn3 = new Button();
            nmbBtn0 = new Button();
            nmbBtnComma = new Button();
            nmbBtnMin = new Button();
            nmbBtnPlus = new Button();
            nmbBtnMult = new Button();
            nmbBtnDiv = new Button();
            nmbBtnCE = new Button();
            nmbBtnEq = new Button();
            SuspendLayout();
            // 
            // resultBox
            // 
            resultBox.Enabled = false;
            resultBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultBox.Location = new Point(12, 23);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(283, 35);
            resultBox.TabIndex = 0;
            // 
            // nmbBtn7
            // 
            nmbBtn7.Cursor = Cursors.Hand;
            nmbBtn7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmbBtn7.Location = new Point(12, 88);
            nmbBtn7.Name = "nmbBtn7";
            nmbBtn7.Size = new Size(60, 60);
            nmbBtn7.TabIndex = 1;
            nmbBtn7.Text = "7";
            nmbBtn7.UseVisualStyleBackColor = true;
            nmbBtn7.Click += AppendToCalculationString;
            // 
            // nmbBtn8
            // 
            nmbBtn8.Cursor = Cursors.Hand;
            nmbBtn8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmbBtn8.Location = new Point(78, 88);
            nmbBtn8.Name = "nmbBtn8";
            nmbBtn8.Size = new Size(60, 60);
            nmbBtn8.TabIndex = 2;
            nmbBtn8.Text = "8";
            nmbBtn8.UseVisualStyleBackColor = true;
            nmbBtn8.Click += AppendToCalculationString;
            // 
            // nmbBtn9
            // 
            nmbBtn9.Cursor = Cursors.Hand;
            nmbBtn9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmbBtn9.Location = new Point(144, 88);
            nmbBtn9.Name = "nmbBtn9";
            nmbBtn9.Size = new Size(60, 60);
            nmbBtn9.TabIndex = 3;
            nmbBtn9.Text = "9";
            nmbBtn9.UseVisualStyleBackColor = true;
            nmbBtn9.Click += AppendToCalculationString;
            // 
            // nmbBtn4
            // 
            nmbBtn4.Cursor = Cursors.Hand;
            nmbBtn4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmbBtn4.Location = new Point(12, 154);
            nmbBtn4.Name = "nmbBtn4";
            nmbBtn4.Size = new Size(60, 60);
            nmbBtn4.TabIndex = 4;
            nmbBtn4.Text = "4";
            nmbBtn4.UseVisualStyleBackColor = true;
            nmbBtn4.Click += AppendToCalculationString;
            // 
            // nmbBtn5
            // 
            nmbBtn5.Cursor = Cursors.Hand;
            nmbBtn5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmbBtn5.Location = new Point(78, 154);
            nmbBtn5.Name = "nmbBtn5";
            nmbBtn5.Size = new Size(60, 60);
            nmbBtn5.TabIndex = 5;
            nmbBtn5.Text = "5";
            nmbBtn5.UseVisualStyleBackColor = true;
            nmbBtn5.Click += AppendToCalculationString;
            // 
            // nmbBtn6
            // 
            nmbBtn6.Cursor = Cursors.Hand;
            nmbBtn6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmbBtn6.Location = new Point(144, 154);
            nmbBtn6.Name = "nmbBtn6";
            nmbBtn6.Size = new Size(60, 60);
            nmbBtn6.TabIndex = 6;
            nmbBtn6.Text = "6";
            nmbBtn6.UseVisualStyleBackColor = true;
            nmbBtn6.Click += AppendToCalculationString;
            // 
            // nmbBtn1
            // 
            nmbBtn1.Cursor = Cursors.Hand;
            nmbBtn1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmbBtn1.Location = new Point(12, 220);
            nmbBtn1.Name = "nmbBtn1";
            nmbBtn1.Size = new Size(60, 60);
            nmbBtn1.TabIndex = 7;
            nmbBtn1.Text = "1";
            nmbBtn1.UseVisualStyleBackColor = true;
            nmbBtn1.Click += AppendToCalculationString;
            // 
            // nmbBtn2
            // 
            nmbBtn2.Cursor = Cursors.Hand;
            nmbBtn2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmbBtn2.Location = new Point(78, 220);
            nmbBtn2.Name = "nmbBtn2";
            nmbBtn2.Size = new Size(60, 60);
            nmbBtn2.TabIndex = 8;
            nmbBtn2.Text = "2";
            nmbBtn2.UseVisualStyleBackColor = true;
            nmbBtn2.Click += AppendToCalculationString;
            // 
            // nmbBtn3
            // 
            nmbBtn3.Cursor = Cursors.Hand;
            nmbBtn3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmbBtn3.Location = new Point(144, 220);
            nmbBtn3.Name = "nmbBtn3";
            nmbBtn3.Size = new Size(60, 60);
            nmbBtn3.TabIndex = 9;
            nmbBtn3.Text = "3";
            nmbBtn3.UseVisualStyleBackColor = true;
            nmbBtn3.Click += AppendToCalculationString;
            // 
            // nmbBtn0
            // 
            nmbBtn0.Cursor = Cursors.Hand;
            nmbBtn0.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmbBtn0.Location = new Point(12, 286);
            nmbBtn0.Name = "nmbBtn0";
            nmbBtn0.Size = new Size(60, 60);
            nmbBtn0.TabIndex = 10;
            nmbBtn0.Text = "0";
            nmbBtn0.UseVisualStyleBackColor = true;
            nmbBtn0.Click += AppendToCalculationString;
            // 
            // nmbBtnComma
            // 
            nmbBtnComma.Cursor = Cursors.Hand;
            nmbBtnComma.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmbBtnComma.Location = new Point(78, 286);
            nmbBtnComma.Name = "nmbBtnComma";
            nmbBtnComma.Size = new Size(60, 60);
            nmbBtnComma.TabIndex = 11;
            nmbBtnComma.Text = ",";
            nmbBtnComma.UseVisualStyleBackColor = true;
            nmbBtnComma.Click += AppendToCalculationString;
            // 
            // nmbBtnMin
            // 
            nmbBtnMin.Cursor = Cursors.Hand;
            nmbBtnMin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmbBtnMin.Location = new Point(233, 286);
            nmbBtnMin.Name = "nmbBtnMin";
            nmbBtnMin.Size = new Size(60, 60);
            nmbBtnMin.TabIndex = 16;
            nmbBtnMin.Text = "-";
            nmbBtnMin.UseVisualStyleBackColor = true;
            nmbBtnMin.Click += AppendToCalculationString;
            // 
            // nmbBtnPlus
            // 
            nmbBtnPlus.Cursor = Cursors.Hand;
            nmbBtnPlus.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmbBtnPlus.Location = new Point(233, 220);
            nmbBtnPlus.Name = "nmbBtnPlus";
            nmbBtnPlus.Size = new Size(60, 60);
            nmbBtnPlus.TabIndex = 15;
            nmbBtnPlus.Text = "+";
            nmbBtnPlus.UseVisualStyleBackColor = true;
            nmbBtnPlus.Click += AppendToCalculationString;
            // 
            // nmbBtnMult
            // 
            nmbBtnMult.Cursor = Cursors.Hand;
            nmbBtnMult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmbBtnMult.Location = new Point(233, 154);
            nmbBtnMult.Name = "nmbBtnMult";
            nmbBtnMult.Size = new Size(60, 60);
            nmbBtnMult.TabIndex = 14;
            nmbBtnMult.Text = "*";
            nmbBtnMult.UseVisualStyleBackColor = true;
            nmbBtnMult.Click += AppendToCalculationString;
            // 
            // nmbBtnDiv
            // 
            nmbBtnDiv.Cursor = Cursors.Hand;
            nmbBtnDiv.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmbBtnDiv.Location = new Point(233, 88);
            nmbBtnDiv.Name = "nmbBtnDiv";
            nmbBtnDiv.Size = new Size(60, 60);
            nmbBtnDiv.TabIndex = 13;
            nmbBtnDiv.Text = "/";
            nmbBtnDiv.UseVisualStyleBackColor = true;
            nmbBtnDiv.Click += AppendToCalculationString;
            // 
            // nmbBtnCE
            // 
            nmbBtnCE.Cursor = Cursors.Hand;
            nmbBtnCE.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmbBtnCE.Location = new Point(144, 286);
            nmbBtnCE.Name = "nmbBtnCE";
            nmbBtnCE.Size = new Size(60, 60);
            nmbBtnCE.TabIndex = 17;
            nmbBtnCE.Text = "CE";
            nmbBtnCE.UseVisualStyleBackColor = true;
            nmbBtnCE.Click += ClearEntry;
            // 
            // nmbBtnEq
            // 
            nmbBtnEq.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmbBtnEq.Location = new Point(12, 370);
            nmbBtnEq.Name = "nmbBtnEq";
            nmbBtnEq.Size = new Size(281, 60);
            nmbBtnEq.TabIndex = 18;
            nmbBtnEq.Text = "=";
            nmbBtnEq.UseVisualStyleBackColor = true;
            nmbBtnEq.Click += EvaluateCalculation;
            // 
            // Application
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 442);
            Controls.Add(nmbBtnEq);
            Controls.Add(nmbBtnCE);
            Controls.Add(nmbBtnMin);
            Controls.Add(nmbBtnPlus);
            Controls.Add(nmbBtnMult);
            Controls.Add(nmbBtnDiv);
            Controls.Add(nmbBtnComma);
            Controls.Add(nmbBtn0);
            Controls.Add(nmbBtn3);
            Controls.Add(nmbBtn2);
            Controls.Add(nmbBtn1);
            Controls.Add(nmbBtn6);
            Controls.Add(nmbBtn5);
            Controls.Add(nmbBtn4);
            Controls.Add(nmbBtn9);
            Controls.Add(nmbBtn8);
            Controls.Add(nmbBtn7);
            Controls.Add(resultBox);
            Name = "Application";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox resultBox;
        private Button nmbBtn7;
        private Button nmbBtn8;
        private Button nmbBtn9;
        private Button nmbBtn4;
        private Button nmbBtn5;
        private Button nmbBtn6;
        private Button nmbBtn1;
        private Button nmbBtn2;
        private Button nmbBtn3;
        private Button nmbBtn0;
        private Button nmbBtnComma;
        private Button nmbBtnMin;
        private Button nmbBtnPlus;
        private Button nmbBtnMult;
        private Button nmbBtnDiv;
        private Button nmbBtnCE;
        private Button nmbBtnEq;
    }
}
