namespace SolverForms.Views
{
    partial class ProblemFiveTabPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProblemFiveTabPage));
            this.inputDataFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.inputInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.eValUpDown = new System.Windows.Forms.NumericUpDown();
            this.processorCountLabel = new System.Windows.Forms.Label();
            this.blockCountLabel = new System.Windows.Forms.Label();
            this.processorUpDown = new System.Windows.Forms.NumericUpDown();
            this.blockUpDown = new System.Windows.Forms.NumericUpDown();
            this.minimumExecTime = new System.Windows.Forms.Label();
            this.minimalExecTimeValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.processReqLabel = new System.Windows.Forms.Label();
            this.processReqCountValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.inputDataFlowLayoutPanel.SuspendLayout();
            this.inputInfoTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eValUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputDataFlowLayoutPanel
            // 
            this.inputDataFlowLayoutPanel.AutoScroll = true;
            this.inputDataFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inputDataFlowLayoutPanel.Controls.Add(this.inputInfoTableLayoutPanel);
            this.inputDataFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputDataFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.inputDataFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.inputDataFlowLayoutPanel.Name = "inputDataFlowLayoutPanel";
            this.inputDataFlowLayoutPanel.Size = new System.Drawing.Size(209, 209);
            this.inputDataFlowLayoutPanel.TabIndex = 1;
            this.inputDataFlowLayoutPanel.WrapContents = false;
            // 
            // inputInfoTableLayoutPanel
            // 
            this.inputInfoTableLayoutPanel.ColumnCount = 2;
            this.inputInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.inputInfoTableLayoutPanel.Controls.Add(this.eValUpDown, 1, 2);
            this.inputInfoTableLayoutPanel.Controls.Add(this.processorCountLabel, 0, 0);
            this.inputInfoTableLayoutPanel.Controls.Add(this.blockCountLabel, 0, 1);
            this.inputInfoTableLayoutPanel.Controls.Add(this.processorUpDown, 1, 0);
            this.inputInfoTableLayoutPanel.Controls.Add(this.blockUpDown, 1, 1);
            this.inputInfoTableLayoutPanel.Controls.Add(this.minimumExecTime, 0, 3);
            this.inputInfoTableLayoutPanel.Controls.Add(this.minimalExecTimeValue, 1, 3);
            this.inputInfoTableLayoutPanel.Controls.Add(this.label1, 0, 2);
            this.inputInfoTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.inputInfoTableLayoutPanel.Name = "inputInfoTableLayoutPanel";
            this.inputInfoTableLayoutPanel.RowCount = 4;
            this.inputInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputInfoTableLayoutPanel.Size = new System.Drawing.Size(199, 120);
            this.inputInfoTableLayoutPanel.TabIndex = 8;
            // 
            // eValUpDown
            // 
            this.eValUpDown.Location = new System.Drawing.Point(156, 61);
            this.eValUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.eValUpDown.Name = "eValUpDown";
            this.eValUpDown.Size = new System.Drawing.Size(40, 23);
            this.eValUpDown.TabIndex = 5;
            this.eValUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // blockCountLabel
            // 
            this.blockCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.blockCountLabel.AutoSize = true;
            this.blockCountLabel.Location = new System.Drawing.Point(3, 29);
            this.blockCountLabel.Name = "blockCountLabel";
            this.blockCountLabel.Size = new System.Drawing.Size(66, 29);
            this.blockCountLabel.TabIndex = 1;
            this.blockCountLabel.Text = "Блоков (s):";
            this.blockCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // processorUpDown
            // 
            this.processorUpDown.Location = new System.Drawing.Point(156, 3);
            this.processorUpDown.Name = "processorUpDown";
            this.processorUpDown.Size = new System.Drawing.Size(40, 23);
            this.processorUpDown.TabIndex = 3;
            this.processorUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // blockUpDown
            // 
            this.blockUpDown.Location = new System.Drawing.Point(156, 32);
            this.blockUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.blockUpDown.Name = "blockUpDown";
            this.blockUpDown.Size = new System.Drawing.Size(40, 23);
            this.blockUpDown.TabIndex = 4;
            this.blockUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // minimumExecTime
            // 
            this.minimumExecTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.minimumExecTime.AutoSize = true;
            this.minimumExecTime.Location = new System.Drawing.Point(3, 87);
            this.minimumExecTime.Name = "minimumExecTime";
            this.minimumExecTime.Size = new System.Drawing.Size(144, 33);
            this.minimumExecTime.TabIndex = 10;
            this.minimumExecTime.Text = "Минимальное время (T):";
            this.minimumExecTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minimalExecTimeValue
            // 
            this.minimalExecTimeValue.Location = new System.Drawing.Point(156, 90);
            this.minimalExecTimeValue.Name = "minimalExecTimeValue";
            this.minimalExecTimeValue.Size = new System.Drawing.Size(39, 23);
            this.minimalExecTimeValue.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Доп. сис. расходы (e):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.processReqLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.processReqCountValue, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(218, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(403, 209);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // processReqLabel
            // 
            this.processReqLabel.AutoSize = true;
            this.processReqLabel.Location = new System.Drawing.Point(3, 0);
            this.processReqLabel.Name = "processReqLabel";
            this.processReqLabel.Size = new System.Drawing.Size(219, 120);
            this.processReqLabel.TabIndex = 0;
            this.processReqLabel.Text = resources.GetString("processReqLabel.Text");
            // 
            // processReqCountValue
            // 
            this.processReqCountValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.processReqCountValue.AutoSize = true;
            this.processReqCountValue.Location = new System.Drawing.Point(228, 0);
            this.processReqCountValue.Name = "processReqCountValue";
            this.processReqCountValue.Size = new System.Drawing.Size(38, 120);
            this.processReqCountValue.TabIndex = 3;
            this.processReqCountValue.Text = "label4";
            this.processReqCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.inputDataFlowLayoutPanel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(624, 215);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // ProblemFiveTabPage
            // 
            this.ClientSize = new System.Drawing.Size(624, 215);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ProblemFiveTabPage";
            this.Text = "инд. 5";
            this.inputDataFlowLayoutPanel.ResumeLayout(false);
            this.inputInfoTableLayoutPanel.ResumeLayout(false);
            this.inputInfoTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eValUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel inputDataFlowLayoutPanel;
        private TableLayoutPanel inputInfoTableLayoutPanel;
        private Label minimumExecTime;
        private Label processorCountLabel;
        private Label blockCountLabel;
        private NumericUpDown processorUpDown;
        private NumericUpDown blockUpDown;
        private TableLayoutPanel tableLayoutPanel1;
        private Label processReqLabel;
        private Label processReqCountValue;
        private TextBox minimalExecTimeValue;
        private Label label1;
        private NumericUpDown eValUpDown;
        private TableLayoutPanel tableLayoutPanel2;
    }
}