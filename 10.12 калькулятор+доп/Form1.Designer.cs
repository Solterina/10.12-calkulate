namespace _10._12_калькулятор_доп
{
    partial class Form1
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
            btn0 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn4 = new Button();
            btn7 = new Button();
            btn5 = new Button();
            btn2 = new Button();
            btn9 = new Button();
            btnEqual = new Button();
            btnAdd = new Button();
            btn8 = new Button();
            btnPercent = new Button();
            btnSubtract = new Button();
            btnSqrt = new Button();
            btnLog = new Button();
            btnSin = new Button();
            btnMultiply = new Button();
            btnFact = new Button();
            btnPower = new Button();
            btnClear = new Button();
            btnTan = new Button();
            btnAbs = new Button();
            btnDot = new Button();
            btnCos = new Button();
            lblDisplay = new Label();
            btnDivide = new Button();
            lblHistory = new Label();
            SuspendLayout();
            // 
            // btn0
            // 
            btn0.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btn0.Location = new Point(99, 497);
            btn0.Name = "btn0";
            btn0.Size = new Size(73, 73);
            btn0.TabIndex = 6;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += Number_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btn3.Location = new Point(195, 416);
            btn3.Name = "btn3";
            btn3.Size = new Size(73, 73);
            btn3.TabIndex = 7;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Number_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btn6.Location = new Point(195, 336);
            btn6.Name = "btn6";
            btn6.Size = new Size(73, 73);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Number_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btn1.Location = new Point(6, 416);
            btn1.Name = "btn1";
            btn1.Size = new Size(73, 73);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Number_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btn4.Location = new Point(6, 335);
            btn4.Name = "btn4";
            btn4.Size = new Size(73, 73);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Number_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btn7.Location = new Point(6, 255);
            btn7.Name = "btn7";
            btn7.Size = new Size(73, 73);
            btn7.TabIndex = 11;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Number_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btn5.Location = new Point(99, 336);
            btn5.Name = "btn5";
            btn5.Size = new Size(73, 73);
            btn5.TabIndex = 13;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Number_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btn2.Location = new Point(99, 417);
            btn2.Name = "btn2";
            btn2.Size = new Size(73, 73);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Number_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btn9.Location = new Point(195, 255);
            btn9.Name = "btn9";
            btn9.Size = new Size(73, 73);
            btn9.TabIndex = 14;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Number_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btnEqual.Location = new Point(481, 497);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(73, 73);
            btnEqual.TabIndex = 18;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btnAdd.Location = new Point(356, 336);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(57, 73);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += Operation_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btn8.Location = new Point(99, 256);
            btn8.Name = "btn8";
            btn8.Size = new Size(73, 73);
            btn8.TabIndex = 12;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Number_Click;
            // 
            // btnPercent
            // 
            btnPercent.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btnPercent.Location = new Point(385, 497);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(73, 73);
            btnPercent.TabIndex = 22;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += btnPercent_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btnSubtract.Location = new Point(426, 336);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(57, 73);
            btnSubtract.TabIndex = 23;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += Operation_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btnSqrt.Location = new Point(289, 416);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(73, 73);
            btnSqrt.TabIndex = 24;
            btnSqrt.Text = "  √ ";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnLog
            // 
            btnLog.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btnLog.Location = new Point(289, 257);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(57, 72);
            btnLog.TabIndex = 25;
            btnLog.Text = "log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Cick;
            // 
            // btnSin
            // 
            btnSin.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btnSin.Location = new Point(356, 258);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(57, 72);
            btnSin.TabIndex = 26;
            btnSin.Text = "sin";
            btnSin.UseVisualStyleBackColor = true;
            btnSin.Click += btnSin_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btnMultiply.Location = new Point(289, 336);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(57, 73);
            btnMultiply.TabIndex = 27;
            btnMultiply.Text = "х";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += Operation_Click;
            // 
            // btnFact
            // 
            btnFact.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btnFact.Location = new Point(385, 416);
            btnFact.Name = "btnFact";
            btnFact.Size = new Size(73, 73);
            btnFact.TabIndex = 30;
            btnFact.Text = "!";
            btnFact.UseVisualStyleBackColor = true;
            btnFact.Click += btnFact_Click;
            // 
            // btnPower
            // 
            btnPower.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btnPower.Location = new Point(481, 416);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(73, 73);
            btnPower.TabIndex = 29;
            btnPower.Text = "x^y";
            btnPower.UseVisualStyleBackColor = true;
            btnPower.Click += Operation_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btnClear.Location = new Point(289, 497);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(73, 73);
            btnClear.TabIndex = 28;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnTan
            // 
            btnTan.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btnTan.Location = new Point(497, 258);
            btnTan.Name = "btnTan";
            btnTan.Size = new Size(57, 72);
            btnTan.TabIndex = 31;
            btnTan.Text = "tan";
            btnTan.UseVisualStyleBackColor = true;
            btnTan.Click += btnTan_Click;
            // 
            // btnAbs
            // 
            btnAbs.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btnAbs.Location = new Point(6, 497);
            btnAbs.Name = "btnAbs";
            btnAbs.Size = new Size(73, 73);
            btnAbs.TabIndex = 33;
            btnAbs.Text = "|x|";
            btnAbs.UseVisualStyleBackColor = true;
            btnAbs.Click += btnAbs_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btnDot.Location = new Point(195, 497);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(73, 73);
            btnDot.TabIndex = 35;
            btnDot.Text = ",";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += Number_Click;
            // 
            // btnCos
            // 
            btnCos.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btnCos.Location = new Point(426, 258);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(57, 72);
            btnCos.TabIndex = 36;
            btnCos.Text = "cos";
            btnCos.UseVisualStyleBackColor = true;
            btnCos.Click += btnCos_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.BackColor = Color.Transparent;
            lblDisplay.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            lblDisplay.ForeColor = SystemColors.Control;
            lblDisplay.Location = new Point(17, 9);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(542, 74);
            lblDisplay.TabIndex = 37;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            btnDivide.Location = new Point(497, 336);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(57, 73);
            btnDivide.TabIndex = 38;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += Operation_Click;
            // 
            // lblHistory
            // 
            lblHistory.Font = new Font("Consolas", 15.75F, FontStyle.Bold);
            lblHistory.Location = new Point(6, 208);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(547, 37);
            lblHistory.TabIndex = 39;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._930;
            ClientSize = new Size(564, 583);
            Controls.Add(lblHistory);
            Controls.Add(btnDivide);
            Controls.Add(lblDisplay);
            Controls.Add(btnCos);
            Controls.Add(btnDot);
            Controls.Add(btnAbs);
            Controls.Add(btnTan);
            Controls.Add(btnFact);
            Controls.Add(btnPower);
            Controls.Add(btnClear);
            Controls.Add(btnMultiply);
            Controls.Add(btnSin);
            Controls.Add(btnLog);
            Controls.Add(btnSqrt);
            Controls.Add(btnSubtract);
            Controls.Add(btnPercent);
            Controls.Add(btnAdd);
            Controls.Add(btnEqual);
            Controls.Add(btn2);
            Controls.Add(btn9);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn4);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn3);
            Controls.Add(btn0);
            Name = "Form1";
            Text = "Калькулятор";
            ResumeLayout(false);
        }

        #endregion

        private Button btn0;
        private Button btn3;
        private Button btn6;
        private Button btn1;
        private Button btn4;
        private Button btn7;
        private Button btn5;
        private Button btn2;
        private Button btn9;
        private Button btnEqual;
        private Button btnAdd;
        private Button btn8;
        private Button btnPercent;
        private Button btnSubtract;
        private Button btnSqrt;
        private Button btnLog;
        private Button btnSin;
        private Button btnMultiply;
        private Button btnFact;
        private Button btnPower;
        private Button btnClear;
        private Button btnTan;
        private Button btnAbs;
        private Button btnDot;
        private Button btnCos;
        private Label lblDisplay;
        private Button btnDivide;
        private Label lblHistory;
    }
}
