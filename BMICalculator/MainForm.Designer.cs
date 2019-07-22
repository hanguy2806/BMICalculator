namespace BMICalculator
{
    partial class BMI_Form
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
            this.radioBtnImperial = new System.Windows.Forms.RadioButton();
            this.radioBtnMetric = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metricUnit = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.inputMeter = new System.Windows.Forms.TextBox();
            this.inputKg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.imperialUnit = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inputInch = new System.Windows.Forms.TextBox();
            this.inputPound = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.numBoard = new System.Windows.Forms.TableLayoutPanel();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.metricUnit.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.imperialUnit.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.numBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioBtnImperial
            // 
            this.radioBtnImperial.AutoSize = true;
            this.radioBtnImperial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnImperial.Location = new System.Drawing.Point(21, 49);
            this.radioBtnImperial.Name = "radioBtnImperial";
            this.radioBtnImperial.Size = new System.Drawing.Size(185, 50);
            this.radioBtnImperial.TabIndex = 0;
            this.radioBtnImperial.TabStop = true;
            this.radioBtnImperial.Text = "Imperial";
            this.radioBtnImperial.UseVisualStyleBackColor = true;
            this.radioBtnImperial.CheckedChanged += new System.EventHandler(this.Imperial_CheckedChanged);
            // 
            // radioBtnMetric
            // 
            this.radioBtnMetric.AutoSize = true;
            this.radioBtnMetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnMetric.Location = new System.Drawing.Point(21, 105);
            this.radioBtnMetric.Name = "radioBtnMetric";
            this.radioBtnMetric.Size = new System.Drawing.Size(236, 50);
            this.radioBtnMetric.TabIndex = 1;
            this.radioBtnMetric.TabStop = true;
            this.radioBtnMetric.Text = "Metric Unit";
            this.radioBtnMetric.UseVisualStyleBackColor = true;
            this.radioBtnMetric.CheckedChanged += new System.EventHandler(this.Metric_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metricUnit);
            this.groupBox1.Controls.Add(this.imperialUnit);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.radioBtnImperial);
            this.groupBox1.Controls.Add(this.radioBtnMetric);
            this.groupBox1.Location = new System.Drawing.Point(45, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 363);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // metricUnit
            // 
            this.metricUnit.Controls.Add(this.label3);
            this.metricUnit.Controls.Add(this.label4);
            this.metricUnit.Controls.Add(this.tableLayoutPanel2);
            this.metricUnit.Location = new System.Drawing.Point(6, 149);
            this.metricUnit.Name = "metricUnit";
            this.metricUnit.Size = new System.Drawing.Size(357, 140);
            this.metricUnit.TabIndex = 10;
            this.metricUnit.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(298, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "m";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.95652F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.04348F));
            this.tableLayoutPanel2.Controls.Add(this.inputMeter, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.inputKg, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(276, 100);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // inputMeter
            // 
            this.inputMeter.Location = new System.Drawing.Point(173, 53);
            this.inputMeter.Name = "inputMeter";
            this.inputMeter.Size = new System.Drawing.Size(98, 26);
            this.inputMeter.TabIndex = 5;
            this.inputMeter.Click += new System.EventHandler(this.activeLabel_Click);
            // 
            // inputKg
            // 
            this.inputKg.Location = new System.Drawing.Point(173, 3);
            this.inputKg.Name = "inputKg";
            this.inputKg.Size = new System.Drawing.Size(98, 26);
            this.inputKg.TabIndex = 4;
            this.inputKg.Click += new System.EventHandler(this.activeLabel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 46);
            this.label8.TabIndex = 3;
            this.label8.Text = "Height";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 46);
            this.label9.TabIndex = 2;
            this.label9.Text = "Weight";
            // 
            // imperialUnit
            // 
            this.imperialUnit.Controls.Add(this.label1);
            this.imperialUnit.Controls.Add(this.label2);
            this.imperialUnit.Controls.Add(this.tableLayoutPanel1);
            this.imperialUnit.Location = new System.Drawing.Point(0, 149);
            this.imperialUnit.Name = "imperialUnit";
            this.imperialUnit.Size = new System.Drawing.Size(357, 140);
            this.imperialUnit.TabIndex = 9;
            this.imperialUnit.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "lb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "in";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.95652F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.04348F));
            this.tableLayoutPanel1.Controls.Add(this.inputInch, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputPound, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(276, 100);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // inputInch
            // 
            this.inputInch.Location = new System.Drawing.Point(173, 53);
            this.inputInch.Name = "inputInch";
            this.inputInch.Size = new System.Drawing.Size(98, 26);
            this.inputInch.TabIndex = 5;
            this.inputInch.Click += new System.EventHandler(this.activeLabel_Click);
            // 
            // inputPound
            // 
            this.inputPound.Location = new System.Drawing.Point(173, 3);
            this.inputPound.Name = "inputPound";
            this.inputPound.Size = new System.Drawing.Size(98, 26);
            this.inputPound.TabIndex = 4;
            this.inputPound.Click += new System.EventHandler(this.activeLabel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 46);
            this.label7.TabIndex = 3;
            this.label7.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 46);
            this.label5.TabIndex = 2;
            this.label5.Text = "Weight";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(12, 295);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(164, 58);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(199, 295);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(164, 58);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Submit";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.CalculateBMI_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(54, 389);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(101, 46);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "BMI:";
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(212, 386);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(162, 58);
            this.btnResult.TabIndex = 4;
            this.btnResult.UseVisualStyleBackColor = false;
            // 
            // numBoard
            // 
            this.numBoard.ColumnCount = 4;
            this.numBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.numBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.numBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.numBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.numBoard.Controls.Add(this.btnDone, 3, 2);
            this.numBoard.Controls.Add(this.btnDot, 2, 3);
            this.numBoard.Controls.Add(this.btn0, 0, 3);
            this.numBoard.Controls.Add(this.btn1, 2, 2);
            this.numBoard.Controls.Add(this.btn2, 1, 2);
            this.numBoard.Controls.Add(this.btn3, 0, 2);
            this.numBoard.Controls.Add(this.btn6, 2, 1);
            this.numBoard.Controls.Add(this.btn5, 1, 1);
            this.numBoard.Controls.Add(this.btn4, 0, 1);
            this.numBoard.Controls.Add(this.btnDelete, 3, 0);
            this.numBoard.Controls.Add(this.btn8, 1, 0);
            this.numBoard.Controls.Add(this.btn7, 0, 0);
            this.numBoard.Controls.Add(this.btnClear, 3, 1);
            this.numBoard.Controls.Add(this.btn9, 2, 0);
            this.numBoard.Location = new System.Drawing.Point(62, 458);
            this.numBoard.Name = "numBoard";
            this.numBoard.RowCount = 4;
            this.numBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.numBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.numBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.numBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.numBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.numBoard.Size = new System.Drawing.Size(315, 185);
            this.numBoard.TabIndex = 5;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Turquoise;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDone.Location = new System.Drawing.Point(237, 95);
            this.btnDone.Name = "btnDone";
            this.numBoard.SetRowSpan(this.btnDone, 2);
            this.btnDone.Size = new System.Drawing.Size(75, 86);
            this.btnDone.TabIndex = 15;
            this.btnDone.Tag = "done";
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.showButton);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.Turquoise;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDot.Location = new System.Drawing.Point(159, 141);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(68, 40);
            this.btnDot.TabIndex = 14;
            this.btnDot.Tag = "decimal";
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.showButton);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Turquoise;
            this.numBoard.SetColumnSpan(this.btn0, 2);
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn0.Location = new System.Drawing.Point(3, 141);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(142, 40);
            this.btn0.TabIndex = 12;
            this.btn0.Tag = "0";
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.showButton);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Turquoise;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn1.Location = new System.Drawing.Point(159, 95);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(68, 40);
            this.btn1.TabIndex = 10;
            this.btn1.Tag = "3";
            this.btn1.Text = "3";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.showButton);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Turquoise;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn2.Location = new System.Drawing.Point(81, 95);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(68, 40);
            this.btn2.TabIndex = 9;
            this.btn2.Tag = "2";
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.showButton);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Turquoise;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn3.Location = new System.Drawing.Point(3, 95);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(68, 40);
            this.btn3.TabIndex = 8;
            this.btn3.Tag = "1";
            this.btn3.Text = "1";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.showButton);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Turquoise;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn6.Location = new System.Drawing.Point(159, 49);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(68, 40);
            this.btn6.TabIndex = 6;
            this.btn6.Tag = "6";
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.showButton);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Turquoise;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn5.Location = new System.Drawing.Point(81, 49);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(68, 40);
            this.btn5.TabIndex = 5;
            this.btn5.Tag = "5";
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.showButton);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Turquoise;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn4.Location = new System.Drawing.Point(3, 49);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(68, 40);
            this.btn4.TabIndex = 4;
            this.btn4.Tag = "4";
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.showButton);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Turquoise;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.Location = new System.Drawing.Point(237, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Tag = "back";
            this.btnDelete.Text = "<=";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.showButton);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Turquoise;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn8.Location = new System.Drawing.Point(81, 3);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(68, 40);
            this.btn8.TabIndex = 1;
            this.btn8.Tag = "8";
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.showButton);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Turquoise;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn7.Location = new System.Drawing.Point(3, 3);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(68, 40);
            this.btn7.TabIndex = 0;
            this.btn7.Tag = "7";
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.showButton);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Turquoise;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClear.Location = new System.Drawing.Point(237, 49);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 40);
            this.btnClear.TabIndex = 7;
            this.btnClear.Tag = "clear";
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.showButton);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Turquoise;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn9.Location = new System.Drawing.Point(159, 3);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(68, 40);
            this.btn9.TabIndex = 2;
            this.btn9.Tag = "9";
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.showButton);
            // 
            // BMI_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 678);
            this.Controls.Add(this.numBoard);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BMI_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMI_Form_Load);
            this.Click += new System.EventHandler(this.BMI_Form_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metricUnit.ResumeLayout(false);
            this.metricUnit.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.imperialUnit.ResumeLayout(false);
            this.imperialUnit.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.numBoard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtnImperial;
        private System.Windows.Forms.RadioButton radioBtnMetric;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox imperialUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox inputInch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputPound;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TableLayoutPanel numBoard;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.GroupBox metricUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox inputMeter;
        private System.Windows.Forms.TextBox inputKg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

