namespace SolverForms
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
            this.components = new System.ComponentModel.Container();
            this.userControl11 = new SolverForms.UserControl1();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.widthSlider = new System.Windows.Forms.TrackBar();
            this.upDownX = new System.Windows.Forms.NumericUpDown();
            this.upDownY = new System.Windows.Forms.NumericUpDown();
            this.lengthSlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.angleSlider = new System.Windows.Forms.TrackBar();
            this.angleLabel = new System.Windows.Forms.Label();
            this.selAngleValue = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.widthSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControl11.Location = new System.Drawing.Point(12, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.ShowBoundaries = false;
            this.userControl11.Size = new System.Drawing.Size(367, 229);
            this.userControl11.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add shape";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 243);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(275, 247);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 19);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "random position";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // widthSlider
            // 
            this.widthSlider.Location = new System.Drawing.Point(63, 301);
            this.widthSlider.Maximum = 25;
            this.widthSlider.Name = "widthSlider";
            this.widthSlider.Size = new System.Drawing.Size(126, 45);
            this.widthSlider.TabIndex = 6;
            this.widthSlider.ValueChanged += new System.EventHandler(this.commonShapeProp_ValueChanged);
            // 
            // upDownX
            // 
            this.upDownX.Location = new System.Drawing.Point(12, 272);
            this.upDownX.Name = "upDownX";
            this.upDownX.Size = new System.Drawing.Size(45, 23);
            this.upDownX.TabIndex = 7;
            this.upDownX.ValueChanged += new System.EventHandler(this.commonShapeProp_ValueChanged);
            // 
            // upDownY
            // 
            this.upDownY.Location = new System.Drawing.Point(63, 272);
            this.upDownY.Name = "upDownY";
            this.upDownY.Size = new System.Drawing.Size(44, 23);
            this.upDownY.TabIndex = 8;
            this.upDownY.ValueChanged += new System.EventHandler(this.commonShapeProp_ValueChanged);
            // 
            // lengthSlider
            // 
            this.lengthSlider.Location = new System.Drawing.Point(63, 352);
            this.lengthSlider.Maximum = 500;
            this.lengthSlider.Name = "lengthSlider";
            this.lengthSlider.Size = new System.Drawing.Size(125, 45);
            this.lengthSlider.SmallChange = 3;
            this.lengthSlider.TabIndex = 9;
            this.lengthSlider.ValueChanged += new System.EventHandler(this.commonShapeProp_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "length";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(275, 272);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(113, 19);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "showBoundaries";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // angleSlider
            // 
            this.angleSlider.Location = new System.Drawing.Point(275, 301);
            this.angleSlider.Maximum = 360;
            this.angleSlider.Name = "angleSlider";
            this.angleSlider.Size = new System.Drawing.Size(104, 45);
            this.angleSlider.TabIndex = 13;
            this.angleSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.angleSlider.ValueChanged += new System.EventHandler(this.commonShapeProp_ValueChanged);
            // 
            // angleLabel
            // 
            this.angleLabel.AutoSize = true;
            this.angleLabel.Location = new System.Drawing.Point(226, 313);
            this.angleLabel.Name = "angleLabel";
            this.angleLabel.Size = new System.Drawing.Size(36, 15);
            this.angleLabel.TabIndex = 14;
            this.angleLabel.Text = "angle";
            // 
            // selAngleValue
            // 
            this.selAngleValue.AutoSize = true;
            this.selAngleValue.Location = new System.Drawing.Point(375, 301);
            this.selAngleValue.Name = "selAngleValue";
            this.selAngleValue.Size = new System.Drawing.Size(38, 15);
            this.selAngleValue.TabIndex = 15;
            this.selAngleValue.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.selAngleValue);
            this.Controls.Add(this.angleLabel);
            this.Controls.Add(this.angleSlider);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lengthSlider);
            this.Controls.Add(this.upDownY);
            this.Controls.Add(this.upDownX);
            this.Controls.Add(this.widthSlider);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.widthSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControl1 userControl11;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private TrackBar widthSlider;
        private NumericUpDown upDownX;
        private NumericUpDown upDownY;
        private TrackBar lengthSlider;
        private Label label1;
        private Label label2;
        private CheckBox checkBox2;
        private TrackBar angleSlider;
        private Label angleLabel;
        private Label selAngleValue;
        private System.Windows.Forms.Timer timer1;
    }
}