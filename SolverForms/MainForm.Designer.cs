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
            this.sourceDataLayout = new System.Windows.Forms.TableLayoutPanel();
            this.sourceMatrixView = new SolverForms.KMatrixView();
            this.resultMatrixView = new SolverForms.KMatrixView();
            this.crtiticalPathLengthLabel = new System.Windows.Forms.Label();
            this.criticalPathLengthValue = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.drawPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.processorCountNumUpDownValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockCountNumUpDownValue)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processCountNumUpDownValue)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.sourceDataLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // processorCountNumUpDownValue
            // 
            this.processorCountNumUpDownValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processorCountNumUpDownValue.Location = new System.Drawing.Point(138, 3);
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
            this.blockCountNumUpDownValue.Location = new System.Drawing.Point(138, 69);
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
            this.processorCountLabel.Size = new System.Drawing.Size(129, 33);
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
            this.blockCountLabel.Location = new System.Drawing.Point(3, 66);
            this.blockCountLabel.Name = "blockCountLabel";
            this.blockCountLabel.Size = new System.Drawing.Size(129, 35);
            this.blockCountLabel.TabIndex = 3;
            this.blockCountLabel.Text = "Блоки (s)";
            this.blockCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.sourceDataLayout.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(180, 101);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // processCountNumUpDownValue
            // 
            this.processCountNumUpDownValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processCountNumUpDownValue.Location = new System.Drawing.Point(138, 36);
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
            this.processCountLabel.Location = new System.Drawing.Point(3, 33);
            this.processCountLabel.Name = "processCountLabel";
            this.processCountLabel.Size = new System.Drawing.Size(129, 33);
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
            this.importButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.importButton.AutoSize = true;
            this.importButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.importButton.Location = new System.Drawing.Point(3, 3);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(1, 25);
            this.importButton.TabIndex = 8;
            this.importButton.Text = "Импорт";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // openJsonFile
            // 
            this.openJsonFile.Filter = "Json-файл|*.json";
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exportButton.AutoSize = true;
            this.exportButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exportButton.Location = new System.Drawing.Point(3, 3);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(1, 25);
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
            // sourceDataLayout
            // 
            this.sourceDataLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceDataLayout.ColumnCount = 2;
            this.sourceDataLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.sourceDataLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.sourceDataLayout.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.sourceDataLayout.Location = new System.Drawing.Point(3, 3);
            this.sourceDataLayout.Name = "sourceDataLayout";
            this.sourceDataLayout.RowCount = 1;
            this.sourceDataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sourceDataLayout.Size = new System.Drawing.Size(0, 107);
            this.sourceDataLayout.TabIndex = 14;
            // 
            // sourceMatrixView
            // 
            this.sourceMatrixView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceMatrixView.BackColor = System.Drawing.SystemColors.Control;
            this.sourceMatrixView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceMatrixView.ColumnCount = 0;
            this.sourceMatrixView.Location = new System.Drawing.Point(3, 116);
            this.sourceMatrixView.Name = "sourceMatrixView";
            this.sourceMatrixView.RowCount = 0;
            this.sourceMatrixView.Size = new System.Drawing.Size(0, 16);
            this.sourceMatrixView.TabIndex = 14;
            // 
            // resultMatrixView
            // 
            this.resultMatrixView.BackColor = System.Drawing.SystemColors.Control;
            this.resultMatrixView.ColumnCount = 0;
            this.resultMatrixView.Location = new System.Drawing.Point(3, 24);
            this.resultMatrixView.Name = "resultMatrixView";
            this.resultMatrixView.RowCount = 0;
            this.resultMatrixView.Size = new System.Drawing.Size(202, 33);
            this.resultMatrixView.TabIndex = 14;
            // 
            // crtiticalPathLengthLabel
            // 
            this.crtiticalPathLengthLabel.AutoSize = true;
            this.crtiticalPathLengthLabel.Location = new System.Drawing.Point(3, 0);
            this.crtiticalPathLengthLabel.Name = "crtiticalPathLengthLabel";
            this.crtiticalPathLengthLabel.Size = new System.Drawing.Size(152, 15);
            this.crtiticalPathLengthLabel.TabIndex = 15;
            this.crtiticalPathLengthLabel.Text = "Длина критического пути:";
            // 
            // criticalPathLengthValue
            // 
            this.criticalPathLengthValue.AutoSize = true;
            this.criticalPathLengthValue.Location = new System.Drawing.Point(161, 0);
            this.criticalPathLengthValue.Name = "criticalPathLengthValue";
            this.criticalPathLengthValue.Size = new System.Drawing.Size(38, 15);
            this.criticalPathLengthValue.TabIndex = 16;
            this.criticalPathLengthValue.Text = "label2";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(583, 530);
            this.splitContainer1.SplitterDistance = 202;
            this.splitContainer1.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel1.Controls.Add(this.sourceDataLayout);
            this.flowLayoutPanel1.Controls.Add(this.sourceMatrixView);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel4);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(196, 524);
            this.flowLayoutPanel1.TabIndex = 16;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.exportButton, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.importButton, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 138);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(0, 31);
            this.tableLayoutPanel4.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(3, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 15;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel2.Controls.Add(this.resultMatrixView);
            this.flowLayoutPanel2.Controls.Add(this.drawPanel);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(371, 524);
            this.flowLayoutPanel2.TabIndex = 16;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.criticalPathLengthValue, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.crtiticalPathLengthLabel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(202, 15);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // drawPanel
            // 
            this.drawPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.drawPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.drawPanel.Location = new System.Drawing.Point(3, 63);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(202, 126);
            this.drawPanel.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 530);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.processorCountNumUpDownValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockCountNumUpDownValue)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processCountNumUpDownValue)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.sourceDataLayout.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

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
        private TableLayoutPanel sourceDataLayout;
        private KMatrixView sourceMatrixView;
        private KMatrixView resultMatrixView;
        private Label crtiticalPathLengthLabel;
        private Label criticalPathLengthValue;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel drawPanel;
    }
}