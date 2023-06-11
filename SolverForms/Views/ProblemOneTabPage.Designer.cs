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
            this.inputDataFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.inputInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.processorCountLabel = new System.Windows.Forms.Label();
            this.saveLoadTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.processCountLabel = new System.Windows.Forms.Label();
            this.blockCountLabel = new System.Windows.Forms.Label();
            this.processUpDown = new System.Windows.Forms.NumericUpDown();
            this.blockUpDown = new System.Windows.Forms.NumericUpDown();
            this.drawPanel = new SolverForms.Views.Controls.UserControl1();
            this.offsetSliderValue = new System.Windows.Forms.TrackBar();
            this.drawingModeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buildCombinedCheckBox = new System.Windows.Forms.CheckBox();
            this.executeMethodComboBox = new System.Windows.Forms.ComboBox();
            this.distributeMethodComboBox = new System.Windows.Forms.ComboBox();
            this.resultMatrixView = new SolverForms.KMatrixView();
            this.matrixInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.criticalPathLenthLabel = new System.Windows.Forms.Label();
            this.criticalPathCountValue = new System.Windows.Forms.Label();
            this.criticalPathLengthValue = new System.Windows.Forms.Label();
            this.selectedPathIndexUpDown = new System.Windows.Forms.NumericUpDown();
            this.criticalPathCountLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.kProcTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.processorUpDown)).BeginInit();
            this.inputDataFlowLayoutPanel.SuspendLayout();
            this.inputInfoTableLayoutPanel.SuspendLayout();
            this.saveLoadTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetSliderValue)).BeginInit();
            this.drawingModeFlowLayoutPanel.SuspendLayout();
            this.matrixInfoTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPathIndexUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kProcTypeBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceMatrixView
            // 
            this.sourceMatrixView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceMatrixView.ColumnCount = 0;
            this.sourceMatrixView.Name = "sourceMatrixView";
            this.sourceMatrixView.ReadOnly = false;
            this.sourceMatrixView.RowCount = 0;
            this.sourceMatrixView.SelectedCells = null;
            this.sourceMatrixView.Size = new System.Drawing.Size(199, 132);
            this.sourceMatrixView.TabIndex = 0;
            // 
            // loadDataButton
            // 
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(75, 23);
            this.loadDataButton.TabIndex = 1;
            this.loadDataButton.Text = "LOAD";
            this.loadDataButton.UseVisualStyleBackColor = true;
            this.loadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // processorUpDown
            // 
            this.processorUpDown.Name = "processorUpDown";
            this.processorUpDown.Size = new System.Drawing.Size(40, 23);
            this.processorUpDown.TabIndex = 3;
            // 
            // inputDataFlowLayoutPanel
            // 
            this.inputDataFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputDataFlowLayoutPanel.AutoScroll = true;
            this.inputDataFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inputDataFlowLayoutPanel.Controls.Add(this.inputInfoTableLayoutPanel);
            this.inputDataFlowLayoutPanel.Controls.Add(this.sourceMatrixView);
            this.inputDataFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.inputDataFlowLayoutPanel.Name = "inputDataFlowLayoutPanel";
            this.inputDataFlowLayoutPanel.Size = new System.Drawing.Size(209, 578);
            this.inputDataFlowLayoutPanel.TabIndex = 0;
            this.inputDataFlowLayoutPanel.WrapContents = false;
            // 
            // inputInfoTableLayoutPanel
            // 
            this.inputInfoTableLayoutPanel.ColumnCount = 2;
            this.inputInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.inputInfoTableLayoutPanel.Controls.Add(this.processorCountLabel, 0, 0);
            this.inputInfoTableLayoutPanel.Controls.Add(this.saveLoadTableLayoutPanel, 0, 3);
            this.inputInfoTableLayoutPanel.Controls.Add(this.processCountLabel, 0, 1);
            this.inputInfoTableLayoutPanel.Controls.Add(this.processorUpDown, 1, 0);
            this.inputInfoTableLayoutPanel.Controls.Add(this.blockCountLabel, 0, 2);
            this.inputInfoTableLayoutPanel.Controls.Add(this.processUpDown, 1, 1);
            this.inputInfoTableLayoutPanel.Controls.Add(this.blockUpDown, 1, 2);
            this.inputInfoTableLayoutPanel.Name = "inputInfoTableLayoutPanel";
            this.inputInfoTableLayoutPanel.RowCount = 4;
            this.inputInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.inputInfoTableLayoutPanel.Size = new System.Drawing.Size(199, 135);
            this.inputInfoTableLayoutPanel.TabIndex = 8;
            // 
            // processorCountLabel
            // 
            this.processorCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.processorCountLabel.AutoSize = true;
            this.processorCountLabel.Name = "processorCountLabel";
            this.processorCountLabel.Size = new System.Drawing.Size(103, 29);
            this.processorCountLabel.TabIndex = 0;
            this.processorCountLabel.Text = "Процессоров (p):";
            this.processorCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveLoadTableLayoutPanel
            // 
            this.saveLoadTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.saveLoadTableLayoutPanel.ColumnCount = 2;
            this.inputInfoTableLayoutPanel.SetColumnSpan(this.saveLoadTableLayoutPanel, 2);
            this.saveLoadTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.saveLoadTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.saveLoadTableLayoutPanel.Controls.Add(this.saveDataButton, 1, 0);
            this.saveLoadTableLayoutPanel.Controls.Add(this.loadDataButton, 0, 0);
            this.saveLoadTableLayoutPanel.Name = "saveLoadTableLayoutPanel";
            this.saveLoadTableLayoutPanel.RowCount = 1;
            this.saveLoadTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.saveLoadTableLayoutPanel.Size = new System.Drawing.Size(193, 31);
            this.saveLoadTableLayoutPanel.TabIndex = 7;
            // 
            // saveDataButton
            // 
            this.saveDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Size = new System.Drawing.Size(75, 23);
            this.saveDataButton.TabIndex = 2;
            this.saveDataButton.Text = "SAVE";
            this.saveDataButton.UseVisualStyleBackColor = true;
            this.saveDataButton.Click += new System.EventHandler(this.saveDataButton_Click);
            // 
            // processCountLabel
            // 
            this.processCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.processCountLabel.AutoSize = true;
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
            this.blockCountLabel.Name = "blockCountLabel";
            this.blockCountLabel.Size = new System.Drawing.Size(66, 29);
            this.blockCountLabel.TabIndex = 2;
            this.blockCountLabel.Text = "Блоков (s):";
            this.blockCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // processUpDown
            // 
            this.processUpDown.Name = "processUpDown";
            this.processUpDown.Size = new System.Drawing.Size(40, 23);
            this.processUpDown.TabIndex = 4;
            // 
            // blockUpDown
            // 
            this.blockUpDown.Name = "blockUpDown";
            this.blockUpDown.Size = new System.Drawing.Size(40, 23);
            this.blockUpDown.TabIndex = 5;
            // 
            // drawPanel
            // 
            this.drawPanel.AutoScroll = true;
            this.drawPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.drawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Scene = null;
            this.drawPanel.Size = new System.Drawing.Size(803, 344);
            this.drawPanel.TabIndex = 8;
            // 
            // offsetSliderValue
            // 
            this.offsetSliderValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.offsetSliderValue.Maximum = 50;
            this.offsetSliderValue.Minimum = 5;
            this.offsetSliderValue.Name = "offsetSliderValue";
            this.offsetSliderValue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.offsetSliderValue.Size = new System.Drawing.Size(45, 344);
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
            this.drawingModeFlowLayoutPanel.Name = "drawingModeFlowLayoutPanel";
            this.drawingModeFlowLayoutPanel.Size = new System.Drawing.Size(322, 29);
            this.drawingModeFlowLayoutPanel.TabIndex = 12;
            // 
            // buildCombinedCheckBox
            // 
            this.buildCombinedCheckBox.AutoSize = true;
            this.buildCombinedCheckBox.Name = "buildCombinedCheckBox";
            this.buildCombinedCheckBox.Size = new System.Drawing.Size(105, 19);
            this.buildCombinedCheckBox.TabIndex = 9;
            this.buildCombinedCheckBox.Text = "Совмещенная";
            this.buildCombinedCheckBox.UseVisualStyleBackColor = true;
            // 
            // executeMethodComboBox
            // 
            this.executeMethodComboBox.FormattingEnabled = true;
            this.executeMethodComboBox.Name = "executeMethodComboBox";
            this.executeMethodComboBox.Size = new System.Drawing.Size(100, 23);
            this.executeMethodComboBox.TabIndex = 14;
            // 
            // distributeMethodComboBox
            // 
            this.distributeMethodComboBox.FormattingEnabled = true;
            this.distributeMethodComboBox.Name = "distributeMethodComboBox";
            this.distributeMethodComboBox.Size = new System.Drawing.Size(99, 23);
            this.distributeMethodComboBox.TabIndex = 14;
            // 
            // resultMatrixView
            // 
            this.resultMatrixView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultMatrixView.ColumnCount = 0;
            this.resultMatrixView.Name = "resultMatrixView";
            this.resultMatrixView.ReadOnly = false;
            this.resultMatrixView.RowCount = 0;
            this.resultMatrixView.SelectedCells = null;
            this.resultMatrixView.Size = new System.Drawing.Size(1, 106);
            this.resultMatrixView.TabIndex = 2;
            // 
            // matrixInfoTableLayoutPanel
            // 
            this.matrixInfoTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matrixInfoTableLayoutPanel.ColumnCount = 3;
            this.matrixInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.matrixInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.matrixInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.matrixInfoTableLayoutPanel.Controls.Add(this.criticalPathLenthLabel, 0, 1);
            this.matrixInfoTableLayoutPanel.Controls.Add(this.criticalPathCountValue, 1, 0);
            this.matrixInfoTableLayoutPanel.Controls.Add(this.criticalPathLengthValue, 1, 1);
            this.matrixInfoTableLayoutPanel.Controls.Add(this.selectedPathIndexUpDown, 2, 0);
            this.matrixInfoTableLayoutPanel.Controls.Add(this.criticalPathCountLabel, 0, 0);
            this.matrixInfoTableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.matrixInfoTableLayoutPanel.Name = "matrixInfoTableLayoutPanel";
            this.matrixInfoTableLayoutPanel.RowCount = 2;
            this.matrixInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.matrixInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.matrixInfoTableLayoutPanel.Size = new System.Drawing.Size(863, 55);
            this.matrixInfoTableLayoutPanel.TabIndex = 7;
            // 
            // criticalPathLenthLabel
            // 
            this.criticalPathLenthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.criticalPathLenthLabel.AutoSize = true;
            this.criticalPathLenthLabel.Name = "criticalPathLenthLabel";
            this.criticalPathLenthLabel.Size = new System.Drawing.Size(152, 28);
            this.criticalPathLenthLabel.TabIndex = 1;
            this.criticalPathLenthLabel.Text = "Длина критического пути:";
            this.criticalPathLenthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // criticalPathCountValue
            // 
            this.criticalPathCountValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.criticalPathCountValue.AutoSize = true;
            this.criticalPathCountValue.Name = "criticalPathCountValue";
            this.criticalPathCountValue.Size = new System.Drawing.Size(38, 27);
            this.criticalPathCountValue.TabIndex = 2;
            this.criticalPathCountValue.Text = "label3";
            this.criticalPathCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // criticalPathLengthValue
            // 
            this.criticalPathLengthValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.criticalPathLengthValue.AutoSize = true;
            this.criticalPathLengthValue.Name = "criticalPathLengthValue";
            this.criticalPathLengthValue.Size = new System.Drawing.Size(38, 28);
            this.criticalPathLengthValue.TabIndex = 3;
            this.criticalPathLengthValue.Text = "label4";
            this.criticalPathLengthValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectedPathIndexUpDown
            // 
            this.selectedPathIndexUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            // criticalPathCountLabel
            // 
            this.criticalPathCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.criticalPathCountLabel.AutoSize = true;
            this.criticalPathCountLabel.Name = "criticalPathCountLabel";
            this.criticalPathCountLabel.Size = new System.Drawing.Size(115, 27);
            this.criticalPathCountLabel.TabIndex = 0;
            this.criticalPathCountLabel.Text = "Критических путей:";
            this.criticalPathCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.inputDataFlowLayoutPanel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1090, 584);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.drawingModeFlowLayoutPanel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.resultMatrixView, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.matrixInfoTableLayoutPanel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(869, 578);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.drawPanel);
            this.flowLayoutPanel1.Controls.Add(this.offsetSliderValue);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(863, 364);
            this.flowLayoutPanel1.TabIndex = 13;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // ProblemOneTabPage
            // 
            this.ClientSize = new System.Drawing.Size(1090, 584);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ProblemOneTabPage";
            this.Text = "инд. 1 & 4";
            ((System.ComponentModel.ISupportInitialize)(this.processorUpDown)).EndInit();
            this.inputDataFlowLayoutPanel.ResumeLayout(false);
            this.inputInfoTableLayoutPanel.ResumeLayout(false);
            this.inputInfoTableLayoutPanel.PerformLayout();
            this.saveLoadTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.processUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetSliderValue)).EndInit();
            this.drawingModeFlowLayoutPanel.ResumeLayout(false);
            this.drawingModeFlowLayoutPanel.PerformLayout();
            this.matrixInfoTableLayoutPanel.ResumeLayout(false);
            this.matrixInfoTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPathIndexUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kProcTypeBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private KMatrixView sourceMatrixView;
        private Button loadDataButton;
        private NumericUpDown processorUpDown;
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
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
#endregion