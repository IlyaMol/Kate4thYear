namespace SolverForms
{
    public partial class KGraphView : UserControl
    {
        public int MatrixRowCount { get; set; }
        public int MatrixColumnCount { get; set; }

        private int[,] _matrixStructure;

        public KGraphView(int rows = 0, int columns = 0)
        {
            InitializeComponent();
            _matrixStructure = new int[rows, columns];
        }

        // Initialize matrix ant fill it with 0
        public void Create()
        {
            for(int rowIndex = 0; rowIndex < _matrixStructure.GetLength(0); rowIndex++)
                for(int columnIndex = 0; columnIndex < _matrixStructure.GetLength(0); columnIndex++)
                    _matrixStructure[rowIndex, columnIndex] = 0;
        }


        private TextBox CreateCell(int initValue = 0, int cellIndex = 1)
        {
            TextBox cellBox = new TextBox();
            cellBox.Location = new Point(3, 3);
            cellBox.Name = $"matrixCellTextBox{cellIndex}";
            cellBox.Size = new Size(23, 23);
            cellBox.TabIndex = 0;
            cellBox.TextAlign = HorizontalAlignment.Center;
            cellBox.Text = initValue.ToString();

            return cellBox;
        }

        private TableLayoutPanel CreateRowContainer(int cellCount = 0, int rowIndex = 1)
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.ColumnCount = cellCount;
            for(int cellIndex = 0; cellIndex <= cellCount; ++cellIndex)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
                tableLayoutPanel.Controls.Add(CreateCell(0, cellIndex));
            }
            tableLayoutPanel.Location = new Point(3, 3);
            tableLayoutPanel.Name = $"matrixRowContainer{rowIndex}";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.TabIndex = 8;

            return tableLayoutPanel;
        }
    }
}