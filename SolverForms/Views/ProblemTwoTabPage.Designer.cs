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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sourceDataFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.processorLabel = new System.Windows.Forms.Label();
            this.processorUpDown = new System.Windows.Forms.NumericUpDown();
            this.processLabel = new System.Windows.Forms.Label();
            this.processUpDown = new System.Windows.Forms.NumericUpDown();
            this.queueTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.sourceDataFlowLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processorUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.sourceDataFlowLayoutPanel);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
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
            this.sourceDataFlowLayoutPanel.Size = new System.Drawing.Size(260, 444);
            this.sourceDataFlowLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.processorLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.processorUpDown, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.processLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.processUpDown, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.queueTextBox, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(257, 88);
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
            this.processorLabel.Size = new System.Drawing.Size(122, 29);
            this.processorLabel.TabIndex = 0;
            this.processorLabel.Text = "Процессоры (p):";
            this.processorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // processorUpDown
            // 
            this.processorUpDown.Location = new System.Drawing.Point(131, 3);
            this.processorUpDown.Name = "processorUpDown";
            this.processorUpDown.Size = new System.Drawing.Size(54, 23);
            this.processorUpDown.TabIndex = 1;
            // 
            // processLabel
            // 
            this.processLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processLabel.AutoSize = true;
            this.processLabel.Location = new System.Drawing.Point(3, 29);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(122, 29);
            this.processLabel.TabIndex = 2;
            this.processLabel.Text = "Процессы (n):";
            this.processLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // processUpDown
            // 
            this.processUpDown.Location = new System.Drawing.Point(131, 32);
            this.processUpDown.Name = "processUpDown";
            this.processUpDown.Size = new System.Drawing.Size(54, 23);
            this.processUpDown.TabIndex = 3;
            // 
            // queueTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.queueTextBox, 2);
            this.queueTextBox.Location = new System.Drawing.Point(3, 61);
            this.queueTextBox.Name = "queueTextBox";
            this.queueTextBox.Size = new System.Drawing.Size(251, 23);
            this.queueTextBox.TabIndex = 4;
            // 
            // ProblemTwoTabPage
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ProblemTwoTabPage";
            this.Text = "ProblemTwoTabPage";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.sourceDataFlowLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processorUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel sourceDataFlowLayoutPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label processorLabel;
        private NumericUpDown processorUpDown;
        private Label processLabel;
        private NumericUpDown processUpDown;
        private TextBox queueTextBox;
    }
}