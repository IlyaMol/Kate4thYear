using SolverForms.Controls;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SolverForms
{
    public partial class KMatrixView : UserControl, INotifyPropertyChanged
    {
        private int[,] _dataSource = new int[0,0];
        public int[,] DataSource 
        { 
            get { return _dataSource; }
            set { _dataSource = value; }
        }

        public int RowCount 
        { 
            get { return _dataSource.GetLength(0); }
            set
            {
                if(RowCount == value) return;
                if(RowCount < value)
                    AddRow();
                else if(RowCount > value)
                    RemoveRow();
                OnPropertyChanged();
            }
        }

        public int ColumnCount 
        { 
            get { return _dataSource.GetLength(1);}
            set
            {
                if(ColumnCount == value) return;
                if(ColumnCount < value)
                    AddColumn();
                else if (ColumnCount > value)
                    RemoveColumn();
                OnPropertyChanged();
            }
        }

        public KMatrixView()
        {
            InitializeComponent();
            matrixRepresentationContainer.Padding = new Padding(0, 0, 0, 0);
            matrixRepresentationContainer.Margin = new Padding(0, 0, 0, 0);
        }

        private void AddRow()
        {
            int[,] newSource = new int[RowCount +1, ColumnCount];
            for(int rowIndex = 0; rowIndex < RowCount; rowIndex++)
                for(int columnIndex = 0; columnIndex < ColumnCount; columnIndex++)
                    newSource[rowIndex, columnIndex] = _dataSource[rowIndex, columnIndex];
            _dataSource = newSource;
            AddRowInView();
        }
        private void RemoveRow()
        {
            int[,] newSource = new int[RowCount - 1, ColumnCount];
            for (int rowIndex = 0; rowIndex < newSource.GetLength(0); rowIndex++)
                for (int columnIndex = 0; columnIndex < newSource.GetLength(1); columnIndex++)
                    newSource[rowIndex, columnIndex] = _dataSource[rowIndex, columnIndex];
            _dataSource = newSource;
            RemoveRowInView();
        }
        private void AddColumn()
        {
            int[,] newSource = new int[RowCount, ColumnCount +1];
            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
                for (int columnIndex = 0; columnIndex < ColumnCount; columnIndex++)
                    newSource[rowIndex, columnIndex] = _dataSource[rowIndex, columnIndex];
            _dataSource = newSource;
            AddColumnInView();
        } 
        private void RemoveColumn()
        {
            int[,] newSource = new int[RowCount, ColumnCount - 1];
            for (int rowIndex = 0; rowIndex < newSource.GetLength(0); rowIndex++)
                for (int columnIndex = 0; columnIndex < newSource.GetLength(1); columnIndex++)
                    newSource[rowIndex, columnIndex] = _dataSource[rowIndex, columnIndex];
            _dataSource = newSource;
            RemoveColumnInView();
        }

        private void AddRowInView()
        {
            matrixRepresentationContainer.SuspendLayout();
            RowLayoutPanel newRowView = CreateRowContainer(ColumnCount, RowCount -1);
            for (int columnIndex = 0; columnIndex < ColumnCount; columnIndex++)
                newRowView.Controls.Add(CreateCell(RowCount, columnIndex));
            matrixRepresentationContainer.Controls.Add(newRowView);
            matrixRepresentationContainer.ResumeLayout();
        }
        private void RemoveRowInView()
        {
            matrixRepresentationContainer.SuspendLayout();
            if (matrixRepresentationContainer.Controls.Count > 0)
                matrixRepresentationContainer.Controls.RemoveAt(matrixRepresentationContainer.Controls.Count-1);
            else if(matrixRepresentationContainer.Controls.Count == 0)
                matrixRepresentationContainer.Controls.RemoveAt(matrixRepresentationContainer.Controls.Count);
            matrixRepresentationContainer.ResumeLayout();
        }
        private void AddColumnInView()
        {
            matrixRepresentationContainer.SuspendLayout();
            for(int rowIndex =0; rowIndex < RowCount; rowIndex++)
            {
                RowLayoutPanel rowView = (RowLayoutPanel)(matrixRepresentationContainer.Controls[rowIndex]);
                
                rowView.Controls.Add(CreateCell(rowIndex, rowView.Controls.Count));
                rowView.ColumnCount++;
            }
            matrixRepresentationContainer.ResumeLayout();
        }
        private void RemoveColumnInView()
        {
            matrixRepresentationContainer.SuspendLayout();
            foreach (RowLayoutPanel rowView in matrixRepresentationContainer.Controls)
            {
                rowView.ColumnCount--;
                if (rowView.Controls.Count > 0)
                    rowView.Controls.RemoveAt(rowView.Controls.Count -1);
                else if (rowView.Controls.Count == 0)
                    rowView.Controls.RemoveAt(rowView.Controls.Count);
            }
            matrixRepresentationContainer.ResumeLayout();
        }

        private CellTextBox CreateCell(int rowIndex, int columnindex)
        {
            CellTextBox cellBox = new CellTextBox();
            cellBox.Name = $"matrixCellTextBox{rowIndex + columnindex}";
            cellBox.RowIndex= rowIndex;
            cellBox.ColumnIndex= columnindex;
            cellBox.TextChanged += CellBox_TextChanged;
            return cellBox;
        }

        private void CellBox_TextChanged(object? sender, CellEventArgs e)
        {
            Debug.WriteLine($"Text changed: {e.NewValue}, row {e.RowIndex}, col {e.ColumnIndex}");
        }

        private RowLayoutPanel CreateRowContainer(int cellCount = 0, int rowIndex = 0)
        {
            RowLayoutPanel tableLayoutPanel = new RowLayoutPanel();
            tableLayoutPanel.ColumnCount = cellCount;
            for (int cellIndex = 0; cellIndex < cellCount; cellIndex++)
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel.Name = $"matrixRowContainer{rowIndex}";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.Index= rowIndex;
            
            Random rnd = new();
            tableLayoutPanel.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));

            return tableLayoutPanel;
        }
        
        #region INotify... implementation
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}