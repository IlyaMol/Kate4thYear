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
            this.sourceMatrixView = new SolverForms.KMatrixView();
            this.loadDataButton = new System.Windows.Forms.Button();
            this.processorUpDown = new System.Windows.Forms.NumericUpDown();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.inputDataFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.inputInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.processorCountLabel = new System.Windows.Forms.Label();
            this.processCountLabel = new System.Windows.Forms.Label();
            this.blockCountLabel = new System.Windows.Forms.Label();
            this.processUpDown = new System.Windows.Forms.NumericUpDown();
            this.blockUpDown = new System.Windows.Forms.NumericUpDown();
            this.copyCountLabel = new System.Windows.Forms.Label();
            this.saveLoadTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.drawingTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.drawPanel = new SolverForms.Views.Controls.UserControl1();
            this.offsetSliderValue = new System.Windows.Forms.TrackBar();
            this.drawingModeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buildCombinedCheckBox = new System.Windows.Forms.CheckBox();
            this.executeMethodComboBox = new System.Windows.Forms.ComboBox();
            this.distributeMethodComboBox = new System.Windows.Forms.ComboBox();
            this.resultMatrixView = new SolverForms.KMatrixView();
            this.matrixInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.criticalPathCountLabel = new System.Windows.Forms.Label();
            this.criticalPathLenthLabel = new System.Windows.Forms.Label();
            this.criticalPathCountValue = new System.Windows.Forms.Label();
            this.criticalPathLengthValue = new System.Windows.Forms.Label();
            this.selectedPathIndexUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.kProcTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourceCopyUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.processorUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.inputDataFlowLayoutPanel.SuspendLayout();
            this.inputInfoTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockUpDown)).BeginInit();
            this.saveLoadTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.drawingTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetSliderValue)).BeginInit();
            this.drawingModeFlowLayoutPanel.SuspendLayout();
            this.matrixInfoTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPathIndexUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kProcTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceCopyUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceMatrixView
            // 
            this.sourceMatrixView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceMatrixView.ColumnCount = 0;
            this.sourceMatrixView.Location = new System.Drawing.Point(3, 162);
            this.sourceMatrixView.Name = "sourceMatrixView";
            this.sourceMatrixView.ReadOnly = false;
            this.sourceMatrixView.RowCount = 0;
            this.sourceMatrixView.SelectedCells = null;
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
            // processorUpDown
            // 
            this.processorUpDown.Location = new System.Drawing.Point(156, 3);
            this.processorUpDown.Name = "processorUpDown";
            this.processorUpDown.Size = new System.Drawing.Size(40, 23);
            this.processorUpDown.TabIndex = 3;
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
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1171, 465);
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
            this.inputDataFlowLayoutPanel.Size = new System.Drawing.Size(208, 459);
            this.inputDataFlowLayoutPanel.TabIndex = 0;
            this.inputDataFlowLayoutPanel.WrapContents = false;
            // 
            // inputInfoTableLayoutPanel
            // 
            this.inputInfoTableLayoutPanel.ColumnCount = 2;
            this.inputInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.inputInfoTableLayoutPanel.Controls.Add(this.resourceCopyUpDown, 0, 3);
            this.inputInfoTableLayoutPanel.Controls.Add(this.processorCountLabel, 0, 0);
            this.inputInfoTableLayoutPanel.Controls.Add(this.processCountLabel, 0, 1);
            this.inputInfoTableLayoutPanel.Controls.Add(this.processorUpDown, 1, 0);
            this.inputInfoTableLayoutPanel.Controls.Add(this.blockCountLabel, 0, 2);
            this.inputInfoTableLayoutPanel.Controls.Add(this.processUpDown, 1, 1);
            this.inputInfoTableLayoutPanel.Controls.Add(this.blockUpDown, 1, 2);
            this.inputInfoTableLayoutPanel.Controls.Add(this.copyCountLabel, 0, 3);
            this.inputInfoTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.inputInfoTableLayoutPanel.Name = "inputInfoTableLayoutPanel";
            this.inputInfoTableLayoutPanel.RowCount = 4;
            this.inputInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputInfoTableLayoutPanel.Size = new System.Drawing.Size(199, 116);
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
            this.blockCountLabel.Size = new System.Drawing.Size(66, 29);
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
            // copyCountLabel
            // 
            this.copyCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyCountLabel.AutoSize = true;
            this.copyCountLabel.Location = new System.Drawing.Point(3, 87);
            this.copyCountLabel.Name = "copyCountLabel";
            this.copyCountLabel.Size = new System.Drawing.Size(147, 29);
            this.copyCountLabel.TabIndex = 6;
            this.copyCountLabel.Text = "Копий ресурса (c):";
            this.copyCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveLoadTableLayoutPanel
            // 
            this.saveLoadTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.saveLoadTableLayoutPanel.ColumnCount = 2;
            this.saveLoadTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.saveLoadTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.saveLoadTableLayoutPanel.Controls.Add(this.saveDataButton, 1, 0);
            this.saveLoadTableLayoutPanel.Controls.Add(this.loadDataButton, 0, 0);
            this.saveLoadTableLayoutPanel.Location = new System.Drawing.Point(3, 125);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.drawingTableLayoutPanel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.drawingModeFlowLayoutPanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.resultMatrixView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.matrixInfoTableLayoutPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(953, 465);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // drawingTableLayoutPanel
            // 
            this.drawingTableLayoutPanel.ColumnCount = 2;
            this.drawingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.drawingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.drawingTableLayoutPanel.Controls.Add(this.drawPanel, 0, 0);
            this.drawingTableLayoutPanel.Controls.Add(this.offsetSliderValue, 1, 0);
            this.drawingTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingTableLayoutPanel.Location = new System.Drawing.Point(3, 188);
            this.drawingTableLayoutPanel.Name = "drawingTableLayoutPanel";
            this.drawingTableLayoutPanel.RowCount = 1;
            this.drawingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.drawingTableLayoutPanel.Size = new System.Drawing.Size(947, 274);
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
            this.drawPanel.Size = new System.Drawing.Size(890, 268);
            this.drawPanel.TabIndex = 8;
            // 
            // offsetSliderValue
            // 
            this.offsetSliderValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.offsetSliderValue.Location = new System.Drawing.Point(899, 3);
            this.offsetSliderValue.Maximum = 50;
            this.offsetSliderValue.Minimum = 5;
            this.offsetSliderValue.Name = "offsetSliderValue";
            this.offsetSliderValue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.offsetSliderValue.Size = new System.Drawing.Size(45, 268);
            this.offsetSliderValue.TabIndex = 9;
            this.offsetSliderValue.Value = 5;
            // 
            // drawingModeFlowLayoutPanel
            // 
            this.drawingModeFlowLayoutPanel.AutoSize = true;
            this.drawingModeFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.drawingModeFlowLayoutPanel.Controls.Add(this.buildCombinedCheckBox);
            this.drawingModeFlowLayoutPanel.Controls.Add(this.executeMethodComboBox);
            this.drawingModeFlowLayoutPanel.Controls.Add(this.distributeMethodComboBox);
            this.drawingModeFlowLayoutPanel.Location = new System.Drawing.Point(3, 153);
            this.drawingModeFlowLayoutPanel.Name = "drawingModeFlowLayoutPanel";
            this.drawingModeFlowLayoutPanel.Size = new System.Drawing.Size(322, 29);
            this.drawingModeFlowLayoutPanel.TabIndex = 12;
            // 
            // buildCombinedCheckBox
            // 
            this.buildCombinedCheckBox.AutoSize = true;
            this.buildCombinedCheckBox.Location = new System.Drawing.Point(3, 3);
            this.buildCombinedCheckBox.Name = "buildCombinedCheckBox";
            this.buildCombinedCheckBox.Size = new System.Drawing.Size(105, 19);
            this.buildCombinedCheckBox.TabIndex = 9;
            this.buildCombinedCheckBox.Text = "Совмещенная";
            this.buildCombinedCheckBox.UseVisualStyleBackColor = true;
            // 
            // executeMethodComboBox
            // 
            this.executeMethodComboBox.FormattingEnabled = true;
            this.executeMethodComboBox.Location = new System.Drawing.Point(114, 3);
            this.executeMethodComboBox.Name = "executeMethodComboBox";
            this.executeMethodComboBox.Size = new System.Drawing.Size(100, 23);
            this.executeMethodComboBox.TabIndex = 14;
            // 
            // distributeMethodComboBox
            // 
            this.distributeMethodComboBox.FormattingEnabled = true;
            this.distributeMethodComboBox.Location = new System.Drawing.Point(220, 3);
            this.distributeMethodComboBox.Name = "distributeMethodComboBox";
            this.distributeMethodComboBox.Size = new System.Drawing.Size(99, 23);
            this.distributeMethodComboBox.TabIndex = 14;
            // 
            // resultMatrixView
            // 
            this.resultMatrixView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultMatrixView.ColumnCount = 0;
            this.resultMatrixView.Location = new System.Drawing.Point(3, 41);
            this.resultMatrixView.Name = "resultMatrixView";
            this.resultMatrixView.ReadOnly = false;
            this.resultMatrixView.RowCount = 0;
            this.resultMatrixView.SelectedCells = null;
            this.resultMatrixView.Size = new System.Drawing.Size(106, 106);
            this.resultMatrixView.TabIndex = 2;
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
            this.matrixInfoTableLayoutPanel.Size = new System.Drawing.Size(890, 32);
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
            // selectedPathIndexUpDown
            // 
            this.selectedPathIndexUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            // resourceCopyUpDown
            // 
            this.resourceCopyUpDown.Location = new System.Drawing.Point(156, 90);
            this.resourceCopyUpDown.Name = "resourceCopyUpDown";
            this.resourceCopyUpDown.Size = new System.Drawing.Size(40, 23);
            this.resourceCopyUpDown.TabIndex = 7;
            // 
            // ProblemOneTabPage
            // 
            this.ClientSize = new System.Drawing.Size(1171, 465);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ProblemOneTabPage";
            this.Text = "Problem one";
            ((System.ComponentModel.ISupportInitialize)(this.processorUpDown)).EndInit();
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.drawingTableLayoutPanel.ResumeLayout(false);
            this.drawingTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetSliderValue)).EndInit();
            this.drawingModeFlowLayoutPanel.ResumeLayout(false);
            this.drawingModeFlowLayoutPanel.PerformLayout();
            this.matrixInfoTableLayoutPanel.ResumeLayout(false);
            this.matrixInfoTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPathIndexUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kProcTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceCopyUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        private KMatrixView sourceMatrixView;
        private Button loadDataButton;
        private NumericUpDown processorUpDown;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel inputDataFlowLayoutPanel;
        private TableLayoutPanel saveLoadTableLayoutPanel;
        private Button saveDataButton;
        private TableLayoutPanel inputInfoTableLayoutPanel;
        private Label processorCountLabel;
        private Label processCountLabel;
        private Label blockCountLabel;
        private NumericUpDown processUpDown;
        private NumericUpDown blockUpDown;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private BindingSource kProcTypeBindingSource;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel drawingTableLayoutPanel;
        private Controls.UserControl1 drawPanel;
        private TrackBar offsetSliderValue;
        private FlowLayoutPanel drawingModeFlowLayoutPanel;
        private CheckBox buildCombinedCheckBox;
        private ComboBox executeMethodComboBox;
        private ComboBox distributeMethodComboBox;
        private KMatrixView resultMatrixView;
        private TableLayoutPanel matrixInfoTableLayoutPanel;
        private Label criticalPathCountLabel;
        private Label criticalPathLenthLabel;
        private Label criticalPathCountValue;
        private Label criticalPathLengthValue;
        private NumericUpDown selectedPathIndexUpDown;
        private Label copyCountLabel;
        private NumericUpDown resourceCopyUpDown;
    }
}
#endregion