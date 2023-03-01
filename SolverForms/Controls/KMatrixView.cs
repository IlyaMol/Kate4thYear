namespace SolverForms
{
    [System.ComponentModel.ComplexBindingProperties("DataSource")]
    public partial class KMatrixView : UserControl
    {
        private int[,] _dataSource = new int[0,0];
        public int[,] DataSource
        {
            get { return _dataSource; }
            set
            {
                if(_dataSource != value)
                CopyArray(_dataSource, ref value);
                _dataSource = value;
                Create();
            }
        }
        public int RowCount 
        { 
            get { return _dataSource.GetLength(0); }
            set
            {
                DataSource = new int[value, _dataSource.GetLength(1)];
            }
        }
        public int ColCount
        {
            get { return _dataSource.GetLength(1); }
            set
            {
                DataSource = new int[_dataSource.GetLength(0), value];
            }
        }

        public KMatrixView()
        {
            InitializeComponent();
        }

        public void Create()
        {
            if (DataSource == null) return;

            matrixRepresentationContainer.Controls.Clear();

            for(int rowIndex = 0; rowIndex < DataSource.GetLength(0); rowIndex++)
            {
                TableLayoutPanel newRowView = CreateRowContainer(DataSource.GetLength(1), rowIndex);
                for (int columnIndex = 0; columnIndex < DataSource.GetLength(1); columnIndex++)
                    newRowView.Controls.Add(CreateCell(rowIndex, columnIndex));
                matrixRepresentationContainer.Controls.Add(newRowView);
            }
        }
        private TextBox CreateCell(int rowIndex, int columnindex)
        {
            TextBox cellBox = new TextBox();
            cellBox.Location = new Point(3, 3);
            cellBox.Name = $"matrixCellTextBox{rowIndex + columnindex}";
            cellBox.Size = new Size(23, 23);
            cellBox.TabIndex = 0;
            cellBox.TextAlign = HorizontalAlignment.Center;
            cellBox.DataBindings.Add("Text", _dataSource[rowIndex, columnindex], "", false, DataSourceUpdateMode.OnPropertyChanged);
            return cellBox;
        }
        private TableLayoutPanel CreateRowContainer(int cellCount = 0, int rowIndex = 0)
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.ColumnCount = cellCount;
            for(int cellIndex = 0; cellIndex < cellCount; cellIndex++)
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel.Location = new Point(3, 3);
            tableLayoutPanel.Name = $"matrixRowContainer{rowIndex}";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.TabIndex = 8;

            return tableLayoutPanel;
        }
        private void CopyArray(int[,] source, ref int[,] dest)
        {
            for(int rowIndex =0; rowIndex < dest.GetLength(0); rowIndex++)
            {
                if(rowIndex < source.GetLength(0))
                    for (int columnIndex = 0; columnIndex < dest.GetLength(1); columnIndex++)
                    {
                        if(columnIndex < source.GetLength(1))
                            dest[rowIndex, columnIndex] = source[rowIndex, columnIndex];
                    }
            }
        }
    }
}