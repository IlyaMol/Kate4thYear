namespace SolverForms
{
    partial class KMatrixView
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
            this.SuspendLayout();
            // 
            // matrixRepresentationContainer
            // 
            this.matrixRepresentationContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.matrixRepresentationContainer.Location = new System.Drawing.Point(3, 3);
            this.matrixRepresentationContainer.Name = "matrixRepresentationContainer";
            this.matrixRepresentationContainer.Size = new System.Drawing.Size(100, 100);
            this.matrixRepresentationContainer.TabIndex = 0;
            // 
            // KMatrixView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.matrixRepresentationContainer);
            this.Name = "KMatrixView";
            this.Size = new System.Drawing.Size(106, 106);
            this.ResumeLayout(false);

        }
        #endregion

        private FlowLayoutPanel matrixRepresentationContainer;
    }
}
