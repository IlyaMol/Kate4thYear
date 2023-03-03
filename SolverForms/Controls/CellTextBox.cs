namespace SolverForms.Controls
{
    public partial class CellTextBox : TextBox
    {
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }

        public delegate void CellEventHandler(object sender, CellEventArgs args);
        public new event CellEventHandler? TextChanged;

        public CellTextBox() : base()
        {
            InitializeComponent();
            base.TextChanged += CellTextBox_TextChanged;

            this.Location = new Point(3, 3);
            this.Size = new Size(23, 23);
            this.TabIndex = 0;
            this.TextAlign = HorizontalAlignment.Center;
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
