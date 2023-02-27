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
            this.processorCountNumUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.blockCountNumUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.processorCountLabel = new System.Windows.Forms.Label();
            this.blockCountLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.processCountNumUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.processCountLabel = new System.Windows.Forms.Label();
            this.buildGraphButton = new System.Windows.Forms.Button();
            this.matrixRepresentationContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.processorCountNumUpDownValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockCountNumUpDownValue)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processCountNumUpDownValue)).BeginInit();
            this.matrixRepresentationContainer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // processorCountNumUpDownValue
            // 
            this.processorCountNumUpDownValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processorCountNumUpDownValue.Location = new System.Drawing.Point(106, 3);
            this.processorCountNumUpDownValue.Name = "processorCountNumUpDownValue";
            this.processorCountNumUpDownValue.Size = new System.Drawing.Size(64, 23);
            this.processorCountNumUpDownValue.TabIndex = 0;
            // 
            // blockCountNumUpDownValue
            // 
            this.blockCountNumUpDownValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blockCountNumUpDownValue.Location = new System.Drawing.Point(106, 60);
            this.blockCountNumUpDownValue.Name = "blockCountNumUpDownValue";
            this.blockCountNumUpDownValue.Size = new System.Drawing.Size(64, 23);
            this.blockCountNumUpDownValue.TabIndex = 1;
            // 
            // processorCountLabel
            // 
            this.processorCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processorCountLabel.AutoSize = true;
            this.processorCountLabel.Location = new System.Drawing.Point(3, 0);
            this.processorCountLabel.Name = "processorCountLabel";
            this.processorCountLabel.Size = new System.Drawing.Size(97, 28);
            this.processorCountLabel.TabIndex = 2;
            this.processorCountLabel.Text = "Процессоры (p)";
            this.processorCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // blockCountLabel
            // 
            this.blockCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blockCountLabel.AutoSize = true;
            this.blockCountLabel.Location = new System.Drawing.Point(3, 57);
            this.blockCountLabel.Name = "blockCountLabel";
            this.blockCountLabel.Size = new System.Drawing.Size(97, 30);
            this.blockCountLabel.TabIndex = 3;
            this.blockCountLabel.Text = "Блоки (s)";
            this.blockCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.53757F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.46243F));
            this.tableLayoutPanel1.Controls.Add(this.processorCountLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.processCountNumUpDownValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.processorCountNumUpDownValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.blockCountLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.processCountLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.blockCountNumUpDownValue, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(173, 87);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // processCountNumUpDownValue
            // 
            this.processCountNumUpDownValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processCountNumUpDownValue.Location = new System.Drawing.Point(106, 31);
            this.processCountNumUpDownValue.Name = "processCountNumUpDownValue";
            this.processCountNumUpDownValue.Size = new System.Drawing.Size(64, 23);
            this.processCountNumUpDownValue.TabIndex = 5;
            // 
            // processCountLabel
            // 
            this.processCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processCountLabel.AutoSize = true;
            this.processCountLabel.Location = new System.Drawing.Point(3, 28);
            this.processCountLabel.Name = "processCountLabel";
            this.processCountLabel.Size = new System.Drawing.Size(97, 29);
            this.processCountLabel.TabIndex = 4;
            this.processCountLabel.Text = "Процессы (n)";
            this.processCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buildGraphButton
            // 
            this.buildGraphButton.Location = new System.Drawing.Point(110, 105);
            this.buildGraphButton.Name = "buildGraphButton";
            this.buildGraphButton.Size = new System.Drawing.Size(75, 23);
            this.buildGraphButton.TabIndex = 6;
            this.buildGraphButton.Text = "Построить";
            this.buildGraphButton.UseVisualStyleBackColor = true;
            this.buildGraphButton.Click += new System.EventHandler(this.BuildGraphButton_Click);
            // 
            // matrixRepresentationContainer
            // 
            this.matrixRepresentationContainer.AutoSize = true;
            this.matrixRepresentationContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matrixRepresentationContainer.Controls.Add(this.tableLayoutPanel2);
            this.matrixRepresentationContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.matrixRepresentationContainer.Location = new System.Drawing.Point(12, 134);
            this.matrixRepresentationContainer.Name = "matrixRepresentationContainer";
            this.matrixRepresentationContainer.Size = new System.Drawing.Size(122, 35);
            this.matrixRepresentationContainer.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox4, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(116, 29);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(23, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(23, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(61, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(23, 23);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(90, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(23, 23);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.textBox5, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(3, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(23, 23);
            this.textBox5.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(32, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(23, 23);
            this.textBox6.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.matrixRepresentationContainer);
            this.Controls.Add(this.buildGraphButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.processorCountNumUpDownValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockCountNumUpDownValue)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processCountNumUpDownValue)).EndInit();
            this.matrixRepresentationContainer.ResumeLayout(false);
            this.matrixRepresentationContainer.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NumericUpDown processorCountNumUpDownValue;
        private NumericUpDown blockCountNumUpDownValue;
        private Label processorCountLabel;
        private Label blockCountLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label processCountLabel;
        private NumericUpDown processCountNumUpDownValue;
        private Button buildGraphButton;
        private FlowLayoutPanel matrixRepresentationContainer;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}