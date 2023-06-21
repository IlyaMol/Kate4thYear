﻿namespace SolverForms.Views
{
    partial class ProblemThreeTabPage
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
            this.inputDataFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.inputInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.processorCountLabel = new System.Windows.Forms.Label();
            this.processCountLabel = new System.Windows.Forms.Label();
            this.processorUpDown = new System.Windows.Forms.NumericUpDown();
            this.copyCountLabel = new System.Windows.Forms.Label();
            this.processUpDown = new System.Windows.Forms.NumericUpDown();
            this.copyUpDown = new System.Windows.Forms.NumericUpDown();
            this.sourceQueueTextBox = new SolverForms.Views.Controls.QueueTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.minimumExecTimeLabel = new System.Windows.Forms.Label();
            this.requiredProcessorCountLabel = new System.Windows.Forms.Label();
            this.minimumProcessorCountLabel = new System.Windows.Forms.Label();
            this.minimumExecTimeValue = new System.Windows.Forms.Label();
            this.requiredProcessorCountValue = new System.Windows.Forms.Label();
            this.minimumProcessorCountValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.inputDataFlowLayoutPanel.SuspendLayout();
            this.inputInfoTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processorUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputDataFlowLayoutPanel
            // 
            this.inputDataFlowLayoutPanel.AutoScroll = true;
            this.inputDataFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inputDataFlowLayoutPanel.Controls.Add(this.inputInfoTableLayoutPanel);
            this.inputDataFlowLayoutPanel.Controls.Add(this.sourceQueueTextBox);
            this.inputDataFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputDataFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.inputDataFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.inputDataFlowLayoutPanel.Name = "inputDataFlowLayoutPanel";
            this.inputDataFlowLayoutPanel.Size = new System.Drawing.Size(209, 205);
            this.inputDataFlowLayoutPanel.TabIndex = 1;
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
            this.inputInfoTableLayoutPanel.Controls.Add(this.copyCountLabel, 0, 2);
            this.inputInfoTableLayoutPanel.Controls.Add(this.processUpDown, 1, 1);
            this.inputInfoTableLayoutPanel.Controls.Add(this.copyUpDown, 1, 2);
            this.inputInfoTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.inputInfoTableLayoutPanel.Name = "inputInfoTableLayoutPanel";
            this.inputInfoTableLayoutPanel.RowCount = 3;
            this.inputInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputInfoTableLayoutPanel.Size = new System.Drawing.Size(199, 106);
            this.inputInfoTableLayoutPanel.TabIndex = 8;
            // 
            // processorCountLabel
            // 
            this.processorCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.processorCountLabel.AutoSize = true;
            this.processorCountLabel.Location = new System.Drawing.Point(3, 0);
            this.processorCountLabel.Name = "processorCountLabel";
            this.processorCountLabel.Size = new System.Drawing.Size(130, 33);
            this.processorCountLabel.TabIndex = 0;
            this.processorCountLabel.Text = "Процессоров (p):";
            this.processorCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // processCountLabel
            // 
            this.processCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.processCountLabel.AutoSize = true;
            this.processCountLabel.Location = new System.Drawing.Point(3, 33);
            this.processCountLabel.Name = "processCountLabel";
            this.processCountLabel.Size = new System.Drawing.Size(111, 33);
            this.processCountLabel.TabIndex = 1;
            this.processCountLabel.Text = "Процессов (n):";
            this.processCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // processorUpDown
            // 
            this.processorUpDown.Location = new System.Drawing.Point(156, 3);
            this.processorUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.processorUpDown.Name = "processorUpDown";
            this.processorUpDown.Size = new System.Drawing.Size(40, 27);
            this.processorUpDown.TabIndex = 3;
            this.processorUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // copyCountLabel
            // 
            this.copyCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.copyCountLabel.AutoSize = true;
            this.copyCountLabel.Location = new System.Drawing.Point(3, 66);
            this.copyCountLabel.Name = "copyCountLabel";
            this.copyCountLabel.Size = new System.Drawing.Size(137, 40);
            this.copyCountLabel.TabIndex = 2;
            this.copyCountLabel.Text = "Копий ресурса (c):";
            this.copyCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // processUpDown
            // 
            this.processUpDown.Location = new System.Drawing.Point(156, 36);
            this.processUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.processUpDown.Name = "processUpDown";
            this.processUpDown.Size = new System.Drawing.Size(40, 27);
            this.processUpDown.TabIndex = 4;
            this.processUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // copyUpDown
            // 
            this.copyUpDown.Location = new System.Drawing.Point(156, 69);
            this.copyUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.copyUpDown.Name = "copyUpDown";
            this.copyUpDown.Size = new System.Drawing.Size(40, 27);
            this.copyUpDown.TabIndex = 5;
            this.copyUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sourceQueueTextBox
            // 
            this.sourceQueueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceQueueTextBox.DataSource = new double[0];
            this.sourceQueueTextBox.Location = new System.Drawing.Point(3, 115);
            this.sourceQueueTextBox.Name = "sourceQueueTextBox";
            this.sourceQueueTextBox.Size = new System.Drawing.Size(199, 27);
            this.sourceQueueTextBox.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.minimumExecTimeLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.requiredProcessorCountLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.minimumProcessorCountLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.minimumExecTimeValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.requiredProcessorCountValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.minimumProcessorCountValue, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(218, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(442, 205);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // minimumExecTimeLabel
            // 
            this.minimumExecTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.minimumExecTimeLabel.AutoSize = true;
            this.minimumExecTimeLabel.Location = new System.Drawing.Point(3, 0);
            this.minimumExecTimeLabel.Name = "minimumExecTimeLabel";
            this.minimumExecTimeLabel.Size = new System.Drawing.Size(253, 28);
            this.minimumExecTimeLabel.TabIndex = 0;
            this.minimumExecTimeLabel.Text = "Минимальное время выполнения:";
            this.minimumExecTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // requiredProcessorCountLabel
            // 
            this.requiredProcessorCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.requiredProcessorCountLabel.AutoSize = true;
            this.requiredProcessorCountLabel.Location = new System.Drawing.Point(3, 28);
            this.requiredProcessorCountLabel.Name = "requiredProcessorCountLabel";
            this.requiredProcessorCountLabel.Size = new System.Drawing.Size(243, 28);
            this.requiredProcessorCountLabel.TabIndex = 1;
            this.requiredProcessorCountLabel.Text = "Достаточное число процессоров:";
            this.requiredProcessorCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // minimumProcessorCountLabel
            // 
            this.minimumProcessorCountLabel.AutoSize = true;
            this.minimumProcessorCountLabel.Location = new System.Drawing.Point(3, 56);
            this.minimumProcessorCountLabel.Name = "minimumProcessorCountLabel";
            this.minimumProcessorCountLabel.Size = new System.Drawing.Size(255, 20);
            this.minimumProcessorCountLabel.TabIndex = 2;
            this.minimumProcessorCountLabel.Text = "Минимальное число процессоров:";
            // 
            // minimumExecTimeValue
            // 
            this.minimumExecTimeValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.minimumExecTimeValue.AutoSize = true;
            this.minimumExecTimeValue.Location = new System.Drawing.Point(264, 0);
            this.minimumExecTimeValue.Name = "minimumExecTimeValue";
            this.minimumExecTimeValue.Size = new System.Drawing.Size(50, 28);
            this.minimumExecTimeValue.TabIndex = 3;
            this.minimumExecTimeValue.Text = "label4";
            this.minimumExecTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // requiredProcessorCountValue
            // 
            this.requiredProcessorCountValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.requiredProcessorCountValue.AutoSize = true;
            this.requiredProcessorCountValue.Location = new System.Drawing.Point(264, 28);
            this.requiredProcessorCountValue.Name = "requiredProcessorCountValue";
            this.requiredProcessorCountValue.Size = new System.Drawing.Size(50, 28);
            this.requiredProcessorCountValue.TabIndex = 4;
            this.requiredProcessorCountValue.Text = "label5";
            this.requiredProcessorCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // minimumProcessorCountValue
            // 
            this.minimumProcessorCountValue.AutoSize = true;
            this.minimumProcessorCountValue.Location = new System.Drawing.Point(264, 56);
            this.minimumProcessorCountValue.Name = "minimumProcessorCountValue";
            this.minimumProcessorCountValue.Size = new System.Drawing.Size(50, 20);
            this.minimumProcessorCountValue.TabIndex = 5;
            this.minimumProcessorCountValue.Text = "label6";
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(663, 211);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ProblemThreeTabPage
            // 
            this.ClientSize = new System.Drawing.Size(663, 211);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ProblemThreeTabPage";
            this.Text = "инд. 3";
            this.inputDataFlowLayoutPanel.ResumeLayout(false);
            this.inputDataFlowLayoutPanel.PerformLayout();
            this.inputInfoTableLayoutPanel.ResumeLayout(false);
            this.inputInfoTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processorUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel inputDataFlowLayoutPanel;
        private TableLayoutPanel inputInfoTableLayoutPanel;
        private Label processorCountLabel;
        private Label processCountLabel;
        private NumericUpDown processorUpDown;
        private Label copyCountLabel;
        private NumericUpDown processUpDown;
        private NumericUpDown copyUpDown;
        private Controls.QueueTextBox sourceQueueTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label minimumExecTimeLabel;
        private Label requiredProcessorCountLabel;
        private Label minimumProcessorCountLabel;
        private Label minimumExecTimeValue;
        private Label requiredProcessorCountValue;
        private Label minimumProcessorCountValue;
        private TableLayoutPanel tableLayoutPanel2;
    }
}