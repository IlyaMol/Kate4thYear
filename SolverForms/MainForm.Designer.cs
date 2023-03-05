namespace SolverForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.processorCountNumUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.blockCountNumUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.processorCountLabel = new System.Windows.Forms.Label();
            this.blockCountLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.processCountNumUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.processCountLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.importButton = new System.Windows.Forms.Button();
            this.openJsonFile = new System.Windows.Forms.OpenFileDialog();
            this.exportButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.sourceDataGroup = new System.Windows.Forms.GroupBox();
            this.sourceDataLayout = new System.Windows.Forms.TableLayoutPanel();
            this.sourceMatrixView = new SolverForms.KMatrixView();
            this.resultMatrixView = new SolverForms.KMatrixView();
            this.crtiticalPathLengthLabel = new System.Windows.Forms.Label();
            this.criticalPathLengthValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.processorCountNumUpDownValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockCountNumUpDownValue)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processCountNumUpDownValue)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.sourceDataGroup.SuspendLayout();
            this.sourceDataLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // processorCountNumUpDownValue
            // 
            this.processorCountNumUpDownValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processorCountNumUpDownValue.Location = new System.Drawing.Point(105, 3);
            this.processorCountNumUpDownValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.processorCountNumUpDownValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.processorCountNumUpDownValue.Name = "processorCountNumUpDownValue";
            this.processorCountNumUpDownValue.Size = new System.Drawing.Size(39, 23);
            this.processorCountNumUpDownValue.TabIndex = 0;
            this.processorCountNumUpDownValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // blockCountNumUpDownValue
            // 
            this.blockCountNumUpDownValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blockCountNumUpDownValue.Location = new System.Drawing.Point(105, 60);
            this.blockCountNumUpDownValue.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.blockCountNumUpDownValue.Name = "blockCountNumUpDownValue";
            this.blockCountNumUpDownValue.Size = new System.Drawing.Size(39, 23);
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
            this.processorCountLabel.Size = new System.Drawing.Size(96, 28);
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
            this.blockCountLabel.Size = new System.Drawing.Size(96, 30);
            this.blockCountLabel.TabIndex = 3;
            this.blockCountLabel.Text = "Блоки (s)";
            this.blockCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.sourceDataLayout.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.processorCountLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.processCountNumUpDownValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.processorCountNumUpDownValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.blockCountLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.processCountLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.blockCountNumUpDownValue, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(147, 87);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // processCountNumUpDownValue
            // 
            this.processCountNumUpDownValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processCountNumUpDownValue.Location = new System.Drawing.Point(105, 31);
            this.processCountNumUpDownValue.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.processCountNumUpDownValue.Name = "processCountNumUpDownValue";
            this.processCountNumUpDownValue.Size = new System.Drawing.Size(39, 23);
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
            this.processCountLabel.Size = new System.Drawing.Size(96, 29);
            this.processCountLabel.TabIndex = 4;
            this.processCountLabel.Text = "Процессы (n)";
            this.processCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // importButton
            // 
            this.importButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importButton.AutoSize = true;
            this.importButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.importButton.Location = new System.Drawing.Point(3, 96);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(61, 25);
            this.importButton.TabIndex = 8;
            this.importButton.Text = "Импорт";
            this.importButton.UseVisualStyleBackColor = true;
            // 
            // openJsonFile
            // 
            this.openJsonFile.Filter = "Json-файл|*.json";
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportButton.AutoSize = true;
            this.exportButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exportButton.Location = new System.Drawing.Point(116, 96);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(62, 25);
            this.exportButton.TabIndex = 9;
            this.exportButton.Text = "Экспорт";
            this.exportButton.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "json";
            this.saveFileDialog.FileName = "sourceData";
            this.saveFileDialog.Filter = "Json-файл|*.json";
            this.saveFileDialog.InitialDirectory = "D:\\";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sourceDataGroup
            // 
            this.sourceDataGroup.Controls.Add(this.sourceDataLayout);
            this.sourceDataGroup.Location = new System.Drawing.Point(12, 12);
            this.sourceDataGroup.Name = "sourceDataGroup";
            this.sourceDataGroup.Size = new System.Drawing.Size(194, 224);
            this.sourceDataGroup.TabIndex = 13;
            this.sourceDataGroup.TabStop = false;
            this.sourceDataGroup.Text = "Дано:";
            // 
            // sourceDataLayout
            // 
            this.sourceDataLayout.ColumnCount = 2;
            this.sourceDataLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.sourceDataLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.sourceDataLayout.Controls.Add(this.sourceMatrixView, 1, 2);
            this.sourceDataLayout.Controls.Add(this.exportButton, 1, 1);
            this.sourceDataLayout.Controls.Add(this.importButton, 0, 1);
            this.sourceDataLayout.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.sourceDataLayout.Location = new System.Drawing.Point(6, 22);
            this.sourceDataLayout.Name = "sourceDataLayout";
            this.sourceDataLayout.RowCount = 3;
            this.sourceDataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sourceDataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sourceDataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sourceDataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sourceDataLayout.Size = new System.Drawing.Size(181, 194);
            this.sourceDataLayout.TabIndex = 14;
            // 
            // sourceMatrixView
            // 
            this.sourceMatrixView.BackColor = System.Drawing.SystemColors.Control;
            this.sourceMatrixView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceMatrixView.ColumnCount = 0;
            this.sourceDataLayout.SetColumnSpan(this.sourceMatrixView, 2);
            this.sourceMatrixView.Location = new System.Drawing.Point(3, 127);
            this.sourceMatrixView.Name = "sourceMatrixView";
            this.sourceMatrixView.RowCount = 0;
            this.sourceMatrixView.Size = new System.Drawing.Size(175, 64);
            this.sourceMatrixView.TabIndex = 14;
            // 
            // resultMatrixView
            // 
            this.resultMatrixView.BackColor = System.Drawing.SystemColors.Control;
            this.resultMatrixView.ColumnCount = 0;
            this.resultMatrixView.Location = new System.Drawing.Point(226, 49);
            this.resultMatrixView.Name = "resultMatrixView";
            this.resultMatrixView.RowCount = 0;
            this.resultMatrixView.Size = new System.Drawing.Size(106, 106);
            this.resultMatrixView.TabIndex = 14;
            // 
            // crtiticalPathLengthLabel
            // 
            this.crtiticalPathLengthLabel.AutoSize = true;
            this.crtiticalPathLengthLabel.Location = new System.Drawing.Point(226, 24);
            this.crtiticalPathLengthLabel.Name = "crtiticalPathLengthLabel";
            this.crtiticalPathLengthLabel.Size = new System.Drawing.Size(152, 15);
            this.crtiticalPathLengthLabel.TabIndex = 15;
            this.crtiticalPathLengthLabel.Text = "Длина критического пути:";
            // 
            // criticalPathLengthValue
            // 
            this.criticalPathLengthValue.AutoSize = true;
            this.criticalPathLengthValue.Location = new System.Drawing.Point(384, 24);
            this.criticalPathLengthValue.Name = "criticalPathLengthValue";
            this.criticalPathLengthValue.Size = new System.Drawing.Size(38, 15);
            this.criticalPathLengthValue.TabIndex = 16;
            this.criticalPathLengthValue.Text = "label2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 583);
            this.Controls.Add(this.criticalPathLengthValue);
            this.Controls.Add(this.crtiticalPathLengthLabel);
            this.Controls.Add(this.resultMatrixView);
            this.Controls.Add(this.sourceDataGroup);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.processorCountNumUpDownValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockCountNumUpDownValue)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processCountNumUpDownValue)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.sourceDataGroup.ResumeLayout(false);
            this.sourceDataLayout.ResumeLayout(false);
            this.sourceDataLayout.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button importButton;
        private OpenFileDialog openJsonFile;
        private Button exportButton;
        private SaveFileDialog saveFileDialog;
        private Button button1;
        private GroupBox sourceDataGroup;
        private TableLayoutPanel sourceDataLayout;
        private KMatrixView sourceMatrixView;
        private KMatrixView resultMatrixView;
        private Label crtiticalPathLengthLabel;
        private Label criticalPathLengthValue;
    }
}