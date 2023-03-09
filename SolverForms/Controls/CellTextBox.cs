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
            base.TextChanged += CellTextBox_TextChanged;
            base.Validated += CellTextBox_Validated;
            base.KeyUp += CellTextBox_KeyUp;
            base.KeyPress += CellTextBox_KeyPress;
            this.Location = new Point(3, 3);
            this.Size = new Size(23, 23);
            this.TabIndex = 0;
            this.TextAlign = HorizontalAlignment.Center;
            this.Multiline = false;
            this.IsSelected= isSelected;
        }

        private void CellTextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CellTextBox_KeyUp(object? sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Debug.WriteLine($"Enter key on: r:{RowIndex} c:{ColumnIndex}");
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
