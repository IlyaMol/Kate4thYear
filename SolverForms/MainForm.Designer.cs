namespace SolverForms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sourceMatrixView = new SolverForms.KMatrixView();
            this.loadDataButton = new System.Windows.Forms.Button();
            this.resultMatrixView = new SolverForms.KMatrixView();
            this.processorUpDown = new System.Windows.Forms.NumericUpDown();
            this.selectedPathIndexUpDown = new System.Windows.Forms.NumericUpDown();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.processorCountLabel = new System.Windows.Forms.Label();
            this.processCountLabel = new System.Windows.Forms.Label();
            this.blockCountLabel = new System.Windows.Forms.Label();
            this.processUpDown = new System.Windows.Forms.NumericUpDown();
            this.blockUpDown = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.busyBar = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.criticalPathCountLabel = new System.Windows.Forms.Label();
            this.criticalPathLenthLabel = new System.Windows.Forms.Label();
            this.criticalPathCountValue = new System.Windows.Forms.Label();
            this.criticalPathLengthValue = new System.Windows.Forms.Label();
            this.drawPanel = new SolverForms.Controls.UserControl1();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buildCombinedCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.processorUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPathIndexUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockUpDown)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceMatrixView
            // 
            this.sourceMatrixView.AutoScroll = true;
            this.sourceMatrixView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceMatrixView.ColumnCount = 0;
            this.sourceMatrixView.Location = new System.Drawing.Point(3, 150);
            this.sourceMatrixView.Name = "sourceMatrixView";
            this.sourceMatrixView.RowCount = 0;
            this.sourceMatrixView.SelectedCells = ((System.Collections.Generic.HashSet<ProblemOne.KCoordinates>)(resources.GetObject("sourceMatrixView.SelectedCells")));
            this.sourceMatrixView.Size = new System.Drawing.Size(199, 132);
            this.sourceMatrixView.TabIndex = 0;
            // 
            // loadDataButton
            // 
            this.loadDataButton.Location = new System.Drawing.Point(3, 3);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(75, 23);
            this.loadDataButton.TabIndex = 1;
            this.loadDataButton.Text = "LOAD";
            this.loadDataButton.UseVisualStyleBackColor = true;
            this.loadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // resultMatrixView
            // 
            this.resultMatrixView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultMatrixView.ColumnCount = 0;
            this.resultMatrixView.Location = new System.Drawing.Point(3, 40);
            this.resultMatrixView.Name = "resultMatrixView";
            this.resultMatrixView.RowCount = 0;
            this.resultMatrixView.SelectedCells = ((System.Collections.Generic.HashSet<ProblemOne.KCoordinates>)(resources.GetObject("resultMatrixView.SelectedCells")));
            this.resultMatrixView.Size = new System.Drawing.Size(106, 106);
            this.resultMatrixView.TabIndex = 2;
            // 
            // processorUpDown
            // 
            this.processorUpDown.Location = new System.Drawing.Point(156, 3);
            this.processorUpDown.Name = "processorUpDown";
            this.processorUpDown.Size = new System.Drawing.Size(40, 23);
            this.processorUpDown.TabIndex = 3;
            // 
            // selectedPathIndexUpDown
            // 
            this.selectedPathIndexUpDown.Location = new System.Drawing.Point(256, 3);
            this.selectedPathIndexUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectedPathIndexUpDown.Name = "selectedPathIndexUpDown";
            this.tableLayoutPanel1.SetRowSpan(this.selectedPathIndexUpDown, 2);
            this.selectedPathIndexUpDown.Size = new System.Drawing.Size(38, 23);
            this.selectedPathIndexUpDown.TabIndex = 4;
            this.selectedPathIndexUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.busyBar);
            this.flowLayoutPanel1.Controls.Add(this.sourceMatrixView);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(205, 444);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.processorCountLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.processCountLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.processorUpDown, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.blockCountLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.processUpDown, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.blockUpDown, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(199, 88);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // processorCountLabel
            // 
            this.processorCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.processorCountLabel.AutoSize = true;
            this.processorCountLabel.Location = new System.Drawing.Point(3, 0);
            this.processorCountLabel.Name = "processorCountLabel";
            this.processorCountLabel.Size = new System.Drawing.Size(103, 29);
            this.processorCountLabel.TabIndex = 0;
            this.processorCountLabel.Text = "Процессоров (n):";
            this.processorCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // processCountLabel
            // 
            this.processCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.processCountLabel.AutoSize = true;
            this.processCountLabel.Location = new System.Drawing.Point(3, 29);
            this.processCountLabel.Name = "processCountLabel";
            this.processCountLabel.Size = new System.Drawing.Size(89, 29);
            this.processCountLabel.TabIndex = 1;
            this.processCountLabel.Text = "Процессов (p):";
            this.processCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blockCountLabel
            // 
            this.blockCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.blockCountLabel.AutoSize = true;
            this.blockCountLabel.Location = new System.Drawing.Point(3, 58);
            this.blockCountLabel.Name = "blockCountLabel";
            this.blockCountLabel.Size = new System.Drawing.Size(66, 30);
            this.blockCountLabel.TabIndex = 2;
            this.blockCountLabel.Text = "Блоков (s):";
            this.blockCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // processUpDown
            // 
            this.processUpDown.Location = new System.Drawing.Point(156, 32);
            this.processUpDown.Name = "processUpDown";
            this.processUpDown.Size = new System.Drawing.Size(40, 23);
            this.processUpDown.TabIndex = 4;
            // 
            // blockUpDown
            // 
            this.blockUpDown.Location = new System.Drawing.Point(156, 61);
            this.blockUpDown.Name = "blockUpDown";
            this.blockUpDown.Size = new System.Drawing.Size(40, 23);
            this.blockUpDown.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.saveDataButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.loadDataButton, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 97);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(199, 31);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // saveDataButton
            // 
            this.saveDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveDataButton.Location = new System.Drawing.Point(121, 3);
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Size = new System.Drawing.Size(75, 23);
            this.saveDataButton.TabIndex = 2;
            this.saveDataButton.Text = "SAVE";
            this.saveDataButton.UseVisualStyleBackColor = true;
            // 
            // busyBar
            // 
            this.busyBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.busyBar.Location = new System.Drawing.Point(3, 134);
            this.busyBar.Name = "busyBar";
            this.busyBar.Size = new System.Drawing.Size(199, 10);
            this.busyBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.busyBar.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.resultMatrixView);
            this.flowLayoutPanel2.Controls.Add(this.buildCombinedCheckBox);
            this.flowLayoutPanel2.Controls.Add(this.drawPanel);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(579, 444);
            this.flowLayoutPanel2.TabIndex = 0;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.criticalPathCountLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.criticalPathLenthLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.criticalPathCountValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.criticalPathLengthValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.selectedPathIndexUpDown, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(297, 31);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // criticalPathCountLabel
            // 
            this.criticalPathCountLabel.AutoSize = true;
            this.criticalPathCountLabel.Location = new System.Drawing.Point(3, 0);
            this.criticalPathCountLabel.Name = "criticalPathCountLabel";
            this.criticalPathCountLabel.Size = new System.Drawing.Size(115, 15);
            this.criticalPathCountLabel.TabIndex = 0;
            this.criticalPathCountLabel.Text = "Критических путей:";
            // 
            // criticalPathLenthLabel
            // 
            this.criticalPathLenthLabel.AutoSize = true;
            this.criticalPathLenthLabel.Location = new System.Drawing.Point(3, 15);
            this.criticalPathLenthLabel.Name = "criticalPathLenthLabel";
            this.criticalPathLenthLabel.Size = new System.Drawing.Size(152, 15);
            this.criticalPathLenthLabel.TabIndex = 1;
            this.criticalPathLenthLabel.Text = "Длина критического пути:";
            // 
            // criticalPathCountValue
            // 
            this.criticalPathCountValue.AutoSize = true;
            this.criticalPathCountValue.Location = new System.Drawing.Point(161, 0);
            this.criticalPathCountValue.Name = "criticalPathCountValue";
            this.criticalPathCountValue.Size = new System.Drawing.Size(38, 15);
            this.criticalPathCountValue.TabIndex = 2;
            this.criticalPathCountValue.Text = "label3";
            // 
            // criticalPathLengthValue
            // 
            this.criticalPathLengthValue.AutoSize = true;
            this.criticalPathLengthValue.Location = new System.Drawing.Point(161, 15);
            this.criticalPathLengthValue.Name = "criticalPathLengthValue";
            this.criticalPathLengthValue.Size = new System.Drawing.Size(38, 15);
            this.criticalPathLengthValue.TabIndex = 3;
            this.criticalPathLengthValue.Text = "label4";
            // 
            // drawPanel
            // 
            this.drawPanel.Location = new System.Drawing.Point(3, 177);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(567, 174);
            this.drawPanel.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buildCombinedCheckBox
            // 
            this.buildCombinedCheckBox.AutoSize = true;
            this.buildCombinedCheckBox.Location = new System.Drawing.Point(3, 152);
            this.buildCombinedCheckBox.Name = "buildCombinedCheckBox";
            this.buildCombinedCheckBox.Size = new System.Drawing.Size(105, 19);
            this.buildCombinedCheckBox.TabIndex = 9;
            this.buildCombinedCheckBox.Text = "Совмещенная";
            this.buildCombinedCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.processorUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPathIndexUpDown)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockUpDown)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private KMatrixView sourceMatrixView;
        private Button loadDataButton;
        private KMatrixView resultMatrixView;
        private NumericUpDown processorUpDown;
        private NumericUpDown selectedPathIndexUpDown;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private ProgressBar busyBar;
        private TableLayoutPanel tableLayoutPanel1;
        private Label criticalPathCountLabel;
        private Label criticalPathLenthLabel;
        private Label criticalPathCountValue;
        private Label criticalPathLengthValue;
        private TableLayoutPanel tableLayoutPanel2;
        private Button saveDataButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Label processorCountLabel;
        private Label processCountLabel;
        private Label blockCountLabel;
        private ContextMenuStrip contextMenuStrip1;
        private NumericUpDown processUpDown;
        private NumericUpDown blockUpDown;
        private Controls.UserControl1 drawPanel;
        private CheckBox buildCombinedCheckBox;
    }
}