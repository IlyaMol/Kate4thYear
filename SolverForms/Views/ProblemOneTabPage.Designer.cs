namespace SolverForms.Views
{
    partial class ProblemOneTabPage
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
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
            this.inputDataFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.inputInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.processorCountLabel = new System.Windows.Forms.Label();
            this.processCountLabel = new System.Windows.Forms.Label();
            this.blockCountLabel = new System.Windows.Forms.Label();
            this.processUpDown = new System.Windows.Forms.NumericUpDown();
            this.blockUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveLoadTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.matrixInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.criticalPathCountLabel = new System.Windows.Forms.Label();
            this.criticalPathLenthLabel = new System.Windows.Forms.Label();
            this.criticalPathCountValue = new System.Windows.Forms.Label();
            this.criticalPathLengthValue = new System.Windows.Forms.Label();
            this.drawingModeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buildCombinedCheckBox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.drawingTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.drawPanel = new SolverForms.Views.Controls.UserControl1();
            this.offsetSliderValue = new System.Windows.Forms.TrackBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.kProcTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.processorUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPathIndexUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.inputDataFlowLayoutPanel.SuspendLayout();
            this.inputInfoTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockUpDown)).BeginInit();
            this.saveLoadTableLayoutPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.matrixInfoTableLayoutPanel.SuspendLayout();
            this.drawingModeFlowLayoutPanel.SuspendLayout();
            this.drawingTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetSliderValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kProcTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceMatrixView
            // 
            this.sourceMatrixView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceMatrixView.ColumnCount = 0;
            this.sourceMatrixView.Location = new System.Drawing.Point(3, 134);
            this.sourceMatrixView.Name = "sourceMatrixView";
            this.sourceMatrixView.ReadOnly = false;
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
            this.resultMatrixView.Location = new System.Drawing.Point(3, 39);
            this.resultMatrixView.Name = "resultMatrixView";
            this.resultMatrixView.ReadOnly = false;
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
            this.selectedPathIndexUpDown.Location = new System.Drawing.Point(205, 3);
            this.selectedPathIndexUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectedPathIndexUpDown.Name = "selectedPathIndexUpDown";
            this.matrixInfoTableLayoutPanel.SetRowSpan(this.selectedPathIndexUpDown, 2);
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
            this.splitContainer1.Panel1.Controls.Add(this.inputDataFlowLayoutPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(805, 578);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.TabIndex = 6;
            // 
            // inputDataFlowLayoutPanel
            // 
            this.inputDataFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputDataFlowLayoutPanel.AutoScroll = true;
            this.inputDataFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inputDataFlowLayoutPanel.Controls.Add(this.inputInfoTableLayoutPanel);
            this.inputDataFlowLayoutPanel.Controls.Add(this.saveLoadTableLayoutPanel);
            this.inputDataFlowLayoutPanel.Controls.Add(this.sourceMatrixView);
            this.inputDataFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.inputDataFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.inputDataFlowLayoutPanel.Name = "inputDataFlowLayoutPanel";
            this.inputDataFlowLayoutPanel.Size = new System.Drawing.Size(208, 572);
            this.inputDataFlowLayoutPanel.TabIndex = 0;
            this.inputDataFlowLayoutPanel.WrapContents = false;
            // 
            // inputInfoTableLayoutPanel
            // 
            this.inputInfoTableLayoutPanel.ColumnCount = 2;
            this.inputInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.inputInfoTableLayoutPanel.Controls.Add(this.processorCountLabel, 0, 0);
            this.inputInfoTableLayoutPanel.Controls.Add(this.processCountLabel, 0, 1);
            this.inputInfoTableLayoutPanel.Controls.Add(this.processorUpDown, 1, 0);
            this.inputInfoTableLayoutPanel.Controls.Add(this.blockCountLabel, 0, 2);
            this.inputInfoTableLayoutPanel.Controls.Add(this.processUpDown, 1, 1);
            this.inputInfoTableLayoutPanel.Controls.Add(this.blockUpDown, 1, 2);
            this.inputInfoTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.inputInfoTableLayoutPanel.Name = "inputInfoTableLayoutPanel";
            this.inputInfoTableLayoutPanel.RowCount = 3;
            this.inputInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputInfoTableLayoutPanel.Size = new System.Drawing.Size(199, 88);
            this.inputInfoTableLayoutPanel.TabIndex = 8;
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
            this.processorCountLabel.Text = "Процессоров (p):";
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
            this.processCountLabel.Text = "Процессов (n):";
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
            // saveLoadTableLayoutPanel
            // 
            this.saveLoadTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.saveLoadTableLayoutPanel.ColumnCount = 2;
            this.saveLoadTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.saveLoadTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.saveLoadTableLayoutPanel.Controls.Add(this.saveDataButton, 1, 0);
            this.saveLoadTableLayoutPanel.Controls.Add(this.loadDataButton, 0, 0);
            this.saveLoadTableLayoutPanel.Location = new System.Drawing.Point(3, 97);
            this.saveLoadTableLayoutPanel.Name = "saveLoadTableLayoutPanel";
            this.saveLoadTableLayoutPanel.RowCount = 1;
            this.saveLoadTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.saveLoadTableLayoutPanel.Size = new System.Drawing.Size(199, 31);
            this.saveLoadTableLayoutPanel.TabIndex = 7;
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
            this.saveDataButton.Click += new System.EventHandler(this.saveDataButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel2.Controls.Add(this.matrixInfoTableLayoutPanel);
            this.flowLayoutPanel2.Controls.Add(this.resultMatrixView);
            this.flowLayoutPanel2.Controls.Add(this.drawingModeFlowLayoutPanel);
            this.flowLayoutPanel2.Controls.Add(this.drawingTableLayoutPanel);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(581, 572);
            this.flowLayoutPanel2.TabIndex = 0;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // matrixInfoTableLayoutPanel
            // 
            this.matrixInfoTableLayoutPanel.ColumnCount = 4;
            this.matrixInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.matrixInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.matrixInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.matrixInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.matrixInfoTableLayoutPanel.Controls.Add(this.criticalPathCountLabel, 0, 0);
            this.matrixInfoTableLayoutPanel.Controls.Add(this.criticalPathLenthLabel, 0, 1);
            this.matrixInfoTableLayoutPanel.Controls.Add(this.criticalPathCountValue, 1, 0);
            this.matrixInfoTableLayoutPanel.Controls.Add(this.criticalPathLengthValue, 1, 1);
            this.matrixInfoTableLayoutPanel.Controls.Add(this.selectedPathIndexUpDown, 2, 0);
            this.matrixInfoTableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.matrixInfoTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.matrixInfoTableLayoutPanel.Name = "matrixInfoTableLayoutPanel";
            this.matrixInfoTableLayoutPanel.RowCount = 2;
            this.matrixInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.matrixInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.matrixInfoTableLayoutPanel.Size = new System.Drawing.Size(567, 30);
            this.matrixInfoTableLayoutPanel.TabIndex = 7;
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
            // drawingModeFlowLayoutPanel
            // 
            this.drawingModeFlowLayoutPanel.AutoSize = true;
            this.drawingModeFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.drawingModeFlowLayoutPanel.Controls.Add(this.buildCombinedCheckBox);
            this.drawingModeFlowLayoutPanel.Controls.Add(this.comboBox1);
            this.drawingModeFlowLayoutPanel.Location = new System.Drawing.Point(3, 151);
            this.drawingModeFlowLayoutPanel.Name = "drawingModeFlowLayoutPanel";
            this.drawingModeFlowLayoutPanel.Size = new System.Drawing.Size(202, 29);
            this.drawingModeFlowLayoutPanel.TabIndex = 12;
            // 
            // buildCombinedCheckBox
            // 
            this.buildCombinedCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buildCombinedCheckBox.AutoSize = true;
            this.buildCombinedCheckBox.Location = new System.Drawing.Point(3, 3);
            this.buildCombinedCheckBox.Name = "buildCombinedCheckBox";
            this.buildCombinedCheckBox.Size = new System.Drawing.Size(105, 23);
            this.buildCombinedCheckBox.TabIndex = 9;
            this.buildCombinedCheckBox.Text = "Совмещенная";
            this.buildCombinedCheckBox.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 23);
            this.comboBox1.TabIndex = 14;
            // 
            // drawingTableLayoutPanel
            // 
            this.drawingTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawingTableLayoutPanel.ColumnCount = 2;
            this.drawingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.drawingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.drawingTableLayoutPanel.Controls.Add(this.drawPanel, 0, 0);
            this.drawingTableLayoutPanel.Controls.Add(this.offsetSliderValue, 1, 0);
            this.drawingTableLayoutPanel.Location = new System.Drawing.Point(3, 186);
            this.drawingTableLayoutPanel.Name = "drawingTableLayoutPanel";
            this.drawingTableLayoutPanel.RowCount = 1;
            this.drawingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.drawingTableLayoutPanel.Size = new System.Drawing.Size(567, 203);
            this.drawingTableLayoutPanel.TabIndex = 13;
            // 
            // drawPanel
            // 
            this.drawPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawPanel.AutoScroll = true;
            this.drawPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.drawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawPanel.Location = new System.Drawing.Point(3, 3);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Scene = null;
            this.drawPanel.Size = new System.Drawing.Size(510, 197);
            this.drawPanel.TabIndex = 8;
            // 
            // offsetSliderValue
            // 
            this.offsetSliderValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.offsetSliderValue.Location = new System.Drawing.Point(519, 3);
            this.offsetSliderValue.Minimum = 1;
            this.offsetSliderValue.Name = "offsetSliderValue";
            this.offsetSliderValue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.offsetSliderValue.Size = new System.Drawing.Size(45, 197);
            this.offsetSliderValue.TabIndex = 9;
            this.offsetSliderValue.Value = 1;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "json";
            this.saveFileDialog1.Filter = "Json files|*.json";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "json";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Json files|*.json|All files|*.*";
            // 
            // kProcTypeBindingSource
            // 
            this.kProcTypeBindingSource.DataSource = typeof(ProblemOne.KProcType);
            // 
            // MainForm
            // 
            this.Controls.Add(this.splitContainer1);
            this.Name = "Problem one";
            this.Text = "Problem one";
            ((System.ComponentModel.ISupportInitialize)(this.processorUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPathIndexUpDown)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.inputDataFlowLayoutPanel.ResumeLayout(false);
            this.inputInfoTableLayoutPanel.ResumeLayout(false);
            this.inputInfoTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockUpDown)).EndInit();
            this.saveLoadTableLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.matrixInfoTableLayoutPanel.ResumeLayout(false);
            this.matrixInfoTableLayoutPanel.PerformLayout();
            this.drawingModeFlowLayoutPanel.ResumeLayout(false);
            this.drawingModeFlowLayoutPanel.PerformLayout();
            this.drawingTableLayoutPanel.ResumeLayout(false);
            this.drawingTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetSliderValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kProcTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
        }

        private KMatrixView sourceMatrixView;
        private Button loadDataButton;
        private KMatrixView resultMatrixView;
        private NumericUpDown processorUpDown;
        private NumericUpDown selectedPathIndexUpDown;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel inputDataFlowLayoutPanel;
        private FlowLayoutPanel flowLayoutPanel2;
        private TableLayoutPanel matrixInfoTableLayoutPanel;
        private Label criticalPathCountLabel;
        private Label criticalPathLenthLabel;
        private Label criticalPathCountValue;
        private Label criticalPathLengthValue;
        private TableLayoutPanel saveLoadTableLayoutPanel;
        private Button saveDataButton;
        private TableLayoutPanel inputInfoTableLayoutPanel;
        private Label processorCountLabel;
        private Label processCountLabel;
        private Label blockCountLabel;
        private NumericUpDown processUpDown;
        private NumericUpDown blockUpDown;
        private Views.Controls.UserControl1 drawPanel;
        private CheckBox buildCombinedCheckBox;
        private FlowLayoutPanel drawingModeFlowLayoutPanel;
        private TableLayoutPanel drawingTableLayoutPanel;
        private TrackBar offsetSliderValue;
        private ComboBox comboBox1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private BindingSource kProcTypeBindingSource;
    }
}
