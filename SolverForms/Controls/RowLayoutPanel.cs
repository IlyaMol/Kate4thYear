using System.Windows.Forms;

namespace SolverForms.Controls
{
    public partial class RowLayoutPanel : TableLayoutPanel
    {
        public int Index { get; set; }

        public RowLayoutPanel() : base()
        {
            InitializeComponent();
            AutoSize = true;
            Padding = new Padding(0, 0, 0, 0);
            Margin = new Padding(0, 0, 0, 0);
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Location = new Point(3, 3);
            TabIndex = 8;
            RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

        }
    }
}
