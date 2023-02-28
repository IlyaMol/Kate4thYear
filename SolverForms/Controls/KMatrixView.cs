using SolverForms.Controls;

namespace SolverForms
{
    [System.ComponentModel.ComplexBindingProperties("DataSource")]
    public partial class KGraphView : UserControl
    {
        KMatrixViewModel ViewModel = new KMatrixViewModel();


        public int[,]? DataSource
        {
            get { return ViewModel.MatrixStructure; }
            set
            {
                if (value == null) return;
                ViewModel.MatrixStructure = value;
                Create();
            }
        }

        public KGraphView()
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

        private TextBox CreateCell(int rowIndex, int cellIndex)
        {
            TextBox cellBox = new TextBox();
            cellBox.Location = new Point(3, 3);
            cellBox.Name = $"matrixCellTextBox{cellIndex}";
            cellBox.Size = new Size(23, 23);
            cellBox.TabIndex = 0;
            cellBox.TextAlign = HorizontalAlignment.Center;
            cellBox.DataBindings.Add("Text", ViewModel.MatrixStructure[rowIndex, cellIndex], "");
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
    }
}