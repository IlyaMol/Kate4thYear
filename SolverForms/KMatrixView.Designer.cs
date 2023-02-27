namespace SolverForms
{
    partial class KGraphView
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
            this.matrixRepresentationContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.matrixRowContainer = new System.Windows.Forms.TableLayoutPanel();
            this.matrixCellTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.matrixRepresentationContainer.SuspendLayout();
            this.matrixRowContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // matrixRepresentationContainer
            // 
            this.matrixRepresentationContainer.AutoSize = true;
            this.matrixRepresentationContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matrixRepresentationContainer.Controls.Add(this.matrixRowContainer);
            this.matrixRepresentationContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.matrixRepresentationContainer.Location = new System.Drawing.Point(14, 58);
            this.matrixRepresentationContainer.Name = "matrixRepresentationContainer";
            this.matrixRepresentationContainer.Size = new System.Drawing.Size(122, 35);
            this.matrixRepresentationContainer.TabIndex = 8;
            // 
            // matrixRowContainer
            // 
            this.matrixRowContainer.AutoSize = true;
            this.matrixRowContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matrixRowContainer.ColumnCount = 4;
            this.matrixRowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.matrixRowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.matrixRowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.matrixRowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.matrixRowContainer.Controls.Add(this.matrixCellTextBox, 0, 0);
            this.matrixRowContainer.Controls.Add(this.textBox2, 1, 0);
            this.matrixRowContainer.Controls.Add(this.textBox3, 2, 0);
            this.matrixRowContainer.Controls.Add(this.textBox4, 3, 0);
            this.matrixRowContainer.Location = new System.Drawing.Point(3, 3);
            this.matrixRowContainer.Name = "matrixRowContainer";
            this.matrixRowContainer.RowCount = 1;
            this.matrixRowContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.matrixRowContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.matrixRowContainer.Size = new System.Drawing.Size(116, 29);
            this.matrixRowContainer.TabIndex = 8;
            // 
            // matrixCellTextBox
            // 
            this.matrixCellTextBox.Location = new System.Drawing.Point(3, 3);
            this.matrixCellTextBox.Name = "matrixCellTextBox";
            this.matrixCellTextBox.Size = new System.Drawing.Size(23, 23);
            this.matrixCellTextBox.TabIndex = 0;
            this.matrixCellTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(23, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(61, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(23, 23);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(90, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(23, 23);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KGraphView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.matrixRepresentationContainer);
            this.Name = "KGraphView";
            this.matrixRepresentationContainer.ResumeLayout(false);
            this.matrixRepresentationContainer.PerformLayout();
            this.matrixRowContainer.ResumeLayout(false);
            this.matrixRowContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel matrixRepresentationContainer;
        private TableLayoutPanel matrixRowContainer;
        private TextBox matrixCellTextBox;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
