using System.Diagnostics;

namespace SolverForms.Controls
{
    public partial class RowLayoutPanel : TableLayoutPanel
    {
        public int Index { get; set; }

        public RowLayoutPanel() : base()
        {
            AutoSize = true;
            AutoSizeMode= AutoSizeMode.GrowAndShrink;
            Padding = new Padding(0, 0, 0, 0);
            Margin = new Padding(0, 0, 0, 0);
            Location = new Point(3, 3);
            TabIndex = 8;
            RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            InitializeComponent();
        }
    }
}
