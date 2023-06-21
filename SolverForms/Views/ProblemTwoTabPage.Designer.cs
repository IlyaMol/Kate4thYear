namespace SolverForms.Views
{
    partial class ProblemTwoTabPage
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
            this.sourceDataFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.processorLabel = new System.Windows.Forms.Label();
            this.processorUpDown = new System.Windows.Forms.NumericUpDown();
            this.processLabel = new System.Windows.Forms.Label();
            this.processUpDown = new System.Windows.Forms.NumericUpDown();
            this.tauLabel = new System.Windows.Forms.Label();
            this.tauUpDown = new System.Windows.Forms.NumericUpDown();
            this.sourceQueueTextBox = new SolverForms.Views.Controls.QueueTextBox();
            this.resultTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.optimalBlockCountValueLabel = new System.Windows.Forms.Label();
            this.uniformedQueueTextBox = new SolverForms.Views.Controls.QueueTextBox();
            this.resultTauLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultTauValueLabel = new System.Windows.Forms.Label();
            this.optimalProcessorCountLabel = new System.Windows.Forms.Label();
            this.optimalProcessorCountValueLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.sourceDataFlowLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processorUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tauUpDown)).BeginInit();
            this.resultTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceDataFlowLayoutPanel
            // 
            this.sourceDataFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceDataFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sourceDataFlowLayoutPanel.Controls.Add(this.tableLayoutPanel1);
            this.sourceDataFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sourceDataFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.sourceDataFlowLayoutPanel.Name = "sourceDataFlowLayoutPanel";
            this.sourceDataFlowLayoutPanel.Size = new System.Drawing.Size(209, 427);
            this.sourceDataFlowLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.2646F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.7354F));
            this.tableLayoutPanel1.Controls.Add(this.processorLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.processorUpDown, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.processLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.processUpDown, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tauLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tauUpDown, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.sourceQueueTextBox, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(203, 139);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // processorLabel
            // 
            this.processorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processorLabel.AutoSize = true;
            this.processorLabel.Location = new System.Drawing.Point(3, 0);
            this.processorLabel.Name = "processorLabel";
            this.processorLabel.Size = new System.Drawing.Size(148, 33);
            this.processorLabel.TabIndex = 0;
            this.processorLabel.Text = "Процессоры (p):";
            this.processorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // processorUpDown
            // 
            this.processorUpDown.Location = new System.Drawing.Point(157, 3);
            this.processorUpDown.Name = "processorUpDown";
            this.processorUpDown.Size = new System.Drawing.Size(43, 27);
            this.processorUpDown.TabIndex = 1;
            // 
            // processLabel
            // 
            this.processLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processLabel.AutoSize = true;
            this.processLabel.Location = new System.Drawing.Point(3, 33);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(148, 33);
            this.processLabel.TabIndex = 2;
            this.processLabel.Text = "Процессы (n):";
            this.processLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // processUpDown
            // 
            this.processUpDown.Location = new System.Drawing.Point(157, 36);
            this.processUpDown.Name = "processUpDown";
            this.processUpDown.Size = new System.Drawing.Size(43, 27);
            this.processUpDown.TabIndex = 3;
            // 
            // tauLabel
            // 
            this.tauLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tauLabel.AutoSize = true;
            this.tauLabel.Location = new System.Drawing.Point(3, 66);
            this.tauLabel.Name = "tauLabel";
            this.tauLabel.Size = new System.Drawing.Size(148, 40);
            this.tauLabel.TabIndex = 5;
            this.tauLabel.Text = "Накладные расходы (τ):";
            this.tauLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tauUpDown
            // 
            this.tauUpDown.Location = new System.Drawing.Point(157, 69);
            this.tauUpDown.Name = "tauUpDown";
            this.tauUpDown.Size = new System.Drawing.Size(43, 27);
            this.tauUpDown.TabIndex = 6;
            // 
            // sourceQueueTextBox
            // 
            this.sourceQueueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.sourceQueueTextBox, 2);
            this.sourceQueueTextBox.DataSource = new double[0];
            this.sourceQueueTextBox.Location = new System.Drawing.Point(3, 109);
            this.sourceQueueTextBox.Name = "sourceQueueTextBox";
            this.sourceQueueTextBox.Size = new System.Drawing.Size(197, 27);
            this.sourceQueueTextBox.TabIndex = 4;
            // 
            // resultTableLayoutPanel
            // 
            this.resultTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTableLayoutPanel.ColumnCount = 2;
            this.resultTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.resultTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.resultTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.resultTableLayoutPanel.Controls.Add(this.optimalBlockCountValueLabel, 1, 2);
            this.resultTableLayoutPanel.Controls.Add(this.uniformedQueueTextBox, 1, 0);
            this.resultTableLayoutPanel.Controls.Add(this.resultTauLabel, 0, 2);
            this.resultTableLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.resultTableLayoutPanel.Controls.Add(this.resultTauValueLabel, 1, 1);
            this.resultTableLayoutPanel.Controls.Add(this.optimalProcessorCountLabel, 0, 3);
            this.resultTableLayoutPanel.Controls.Add(this.optimalProcessorCountValueLabel, 1, 3);
            this.resultTableLayoutPanel.Location = new System.Drawing.Point(218, 3);
            this.resultTableLayoutPanel.Name = "resultTableLayoutPanel";
            this.resultTableLayoutPanel.RowCount = 4;
            this.resultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.resultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.resultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.resultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.resultTableLayoutPanel.Size = new System.Drawing.Size(659, 427);
            this.resultTableLayoutPanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Равномерное структирирование:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optimalBlockCountValueLabel
            // 
            this.optimalBlockCountValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optimalBlockCountValueLabel.AutoSize = true;
            this.optimalBlockCountValueLabel.Location = new System.Drawing.Point(295, 56);
            this.optimalBlockCountValueLabel.Name = "optimalBlockCountValueLabel";
            this.optimalBlockCountValueLabel.Size = new System.Drawing.Size(420, 20);
            this.optimalBlockCountValueLabel.TabIndex = 5;
            this.optimalBlockCountValueLabel.Text = "label5";
            this.optimalBlockCountValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uniformedQueueTextBox
            // 
            this.uniformedQueueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uniformedQueueTextBox.DataSource = new double[0];
            this.uniformedQueueTextBox.Location = new System.Drawing.Point(295, 3);
            this.uniformedQueueTextBox.Name = "uniformedQueueTextBox";
            this.uniformedQueueTextBox.Size = new System.Drawing.Size(420, 27);
            this.uniformedQueueTextBox.TabIndex = 1;
            // 
            // resultTauLabel
            // 
            this.resultTauLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTauLabel.AutoSize = true;
            this.resultTauLabel.Location = new System.Drawing.Point(3, 56);
            this.resultTauLabel.Name = "resultTauLabel";
            this.resultTauLabel.Size = new System.Drawing.Size(286, 20);
            this.resultTauLabel.TabIndex = 4;
            this.resultTauLabel.Text = "Оптимальное число блоков при τ = 1:";
            this.resultTauLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Оценка величины накладных расходов:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resultTauValueLabel
            // 
            this.resultTauValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTauValueLabel.AutoSize = true;
            this.resultTauValueLabel.Location = new System.Drawing.Point(295, 28);
            this.resultTauValueLabel.Name = "resultTauValueLabel";
            this.resultTauValueLabel.Size = new System.Drawing.Size(420, 20);
            this.resultTauValueLabel.TabIndex = 3;
            this.resultTauValueLabel.Text = "label3";
            this.resultTauValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optimalProcessorCountLabel
            // 
            this.optimalProcessorCountLabel.AutoSize = true;
            this.optimalProcessorCountLabel.Location = new System.Drawing.Point(3, 84);
            this.optimalProcessorCountLabel.Name = "optimalProcessorCountLabel";
            this.optimalProcessorCountLabel.Size = new System.Drawing.Size(250, 20);
            this.optimalProcessorCountLabel.TabIndex = 6;
            this.optimalProcessorCountLabel.Text = "Оптимальное число процессоров:";
            // 
            // optimalProcessorCountValueLabel
            // 
            this.optimalProcessorCountValueLabel.AutoSize = true;
            this.optimalProcessorCountValueLabel.Location = new System.Drawing.Point(295, 84);
            this.optimalProcessorCountValueLabel.Name = "optimalProcessorCountValueLabel";
            this.optimalProcessorCountValueLabel.Size = new System.Drawing.Size(50, 20);
            this.optimalProcessorCountValueLabel.TabIndex = 7;
            this.optimalProcessorCountValueLabel.Text = "label3";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.resultTableLayoutPanel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.sourceDataFlowLayoutPanel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(880, 433);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ProblemTwoTabPage
            // 
            this.ClientSize = new System.Drawing.Size(880, 433);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ProblemTwoTabPage";
            this.Text = "инд. 2";
            this.sourceDataFlowLayoutPanel.ResumeLayout(false);
            this.sourceDataFlowLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processorUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tauUpDown)).EndInit();
            this.resultTableLayoutPanel.ResumeLayout(false);
            this.resultTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel sourceDataFlowLayoutPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label processorLabel;
        private NumericUpDown processorUpDown;
        private Label processLabel;
        private NumericUpDown processUpDown;
        private Controls.QueueTextBox sourceQueueTextBox;
        private Label optimalBlockCountValueLabel;
        private Label resultTauLabel;
        private Label resultTauValueLabel;
        private Label label2;
        private Controls.QueueTextBox uniformedQueueTextBox;
        private Label label1;
        private Label tauLabel;
        private NumericUpDown tauUpDown;
        private TableLayoutPanel resultTableLayoutPanel;
        private Label optimalProcessorCountLabel;
        private Label optimalProcessorCountValueLabel;
        private TableLayoutPanel tableLayoutPanel2;
    }
}