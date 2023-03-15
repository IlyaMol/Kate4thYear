using System.Diagnostics;

namespace SolverForms.Controls
{
    public partial class CellTextBox : TextBox
    {
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
        public bool IsNumeric { get; set; } = false;
        public bool IsSelected 
        { 
            get; 
            set; 
        } = false;

        public Color SelectedColor { get; set; } = Color.LightGreen;

        public delegate void CellEventHandler(object sender, CellEventArgs args);
        public new event CellEventHandler? TextChanged;
        public new event CellEventHandler? Validated;

        public CellTextBox(bool isSelected = false) : base()
        {
            InitializeComponent();
            this.SuspendLayout();
            base.TextChanged += CellTextBox_TextChanged;
            base.Validated += CellTextBox_Validated;
            base.KeyPress += CellTextBox_KeyPress;
            base.ReadOnlyChanged += CellTextBox_ReadOnlyChanged;
            this.Location = new Point(3, 3);
            this.Size = new Size(23, 23);
            this.TabIndex = 0;
            this.TextAlign = HorizontalAlignment.Center;
            this.Multiline = false;
            this.IsSelected= isSelected;
            this.HideSelection = true;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void CellTextBox_ReadOnlyChanged(object? sender, EventArgs e)
        {
            if(sender == null) return;

            this.SuspendLayout();
            if (((CellTextBox)sender).ReadOnly)
            {
                ((CellTextBox)sender).BorderStyle = BorderStyle.FixedSingle;
                ((CellTextBox)sender).Margin = new Padding(0);
            }
            else
                ((CellTextBox)sender).BorderStyle = BorderStyle.Fixed3D;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void CellTextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CellTextBox_Validated(object? sender, EventArgs e)
        {
            if (sender?.GetType() == typeof(CellTextBox))
            {
                if (this.Modified)
                {
                    this.Validated?.Invoke(this, new CellEventArgs()
                    {
                        RowIndex = ((CellTextBox)sender).RowIndex,
                        ColumnIndex = ((CellTextBox)sender).ColumnIndex,
                        NewValue = ((CellTextBox)sender).Text
                    });
                    this.Modified = false;
                }
            }
        }

        private void CellTextBox_TextChanged(object? sender, EventArgs e)
        {
            if(sender?.GetType() == typeof(CellTextBox))
            {
                this.TextChanged?.Invoke(this, new CellEventArgs()
                {
                    RowIndex = ((CellTextBox)sender).RowIndex,
                    ColumnIndex = ((CellTextBox)sender).ColumnIndex,
                    NewValue = ((CellTextBox)sender).Text
                });
            }
        }
    }

    public class CellEventArgs
    {
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
        public string NewValue { get; set; } = string.Empty;
    }

}
