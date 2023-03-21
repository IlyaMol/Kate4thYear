using ProblemOne;
using SolverForms.Controls;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SolverForms
{
    public partial class KMatrixView : UserControl, INotifyPropertyChanged
    {
        public delegate void DataSourceChangedDelegate(int[,] newDataSource);
        public event DataSourceChangedDelegate? DataSourceChanged;

        private int[,] _dataSource = new int[0, 0];
        private int[,] dataSource
        {
            get { return _dataSource; }
            set
            {
                if (IsIdentical(ref _dataSource, ref value)) return;
                _dataSource = value;
                Rebuild();
                OnPropertyChanged(nameof(DataSource));
                DataSourceChanged?.Invoke(_dataSource);
            }
        }
        public int[,] DataSource 
        {
            get 
            { 
                return dataSource; 
            }
            set 
            { 
                if(IsIdentical(ref _dataSource, ref value)) return;
                dataSource = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(RowCount));
                OnPropertyChanged(nameof(ColumnCount));
            }
        }

        public bool ReadOnly { get; set; } = false;

        public int RowCount 
        { 
            get { return dataSource.GetLength(0); }
            set
            {
                if(RowCount == value) return;
                if(RowCount < value)
                    AddRow(value - RowCount);
                else if(RowCount > value)
                    RemoveRow(RowCount - value);
                OnPropertyChanged();
            }
        }
        public int ColumnCount 
        { 
            get { return dataSource.GetLength(1);}
            set
            {
                if(ColumnCount == value) return;
                if(ColumnCount < value)
                    AddColumn(value - ColumnCount);
                else if (ColumnCount > value)
                    RemoveColumn(ColumnCount - value);
                OnPropertyChanged();
            }
        }

        public HashSet<KCoordinates> selectedCells = new HashSet<KCoordinates>();
        public HashSet<KCoordinates> SelectedCells
        {
            get
            {
                return selectedCells;
            }
            set
            {
                if(selectedCells == value) return;
                selectedCells = value;
                PaintCriticalPath();
                OnPropertyChanged();
            }
        }

        public KMatrixView()
        {
            DoubleBuffered = true;
            InitializeComponent();
            matrixRepresentationContainer.Padding = new Padding(0, 0, 0, 0);
            matrixRepresentationContainer.Margin = new Padding(0, 0, 0, 0);
            matrixRepresentationContainer.Location = new Point(0, 0);
            matrixRepresentationContainer.WrapContents = false;
            matrixRepresentationContainer.AutoSize = true;
            matrixRepresentationContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            
        }

        private void AddRow(int count = 1)
        {
            int[,] newSource = new int[RowCount + count, ColumnCount];
            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
                for (int columnIndex = 0; columnIndex < ColumnCount; columnIndex++)
                    newSource[rowIndex, columnIndex] = dataSource[rowIndex, columnIndex];
            dataSource = newSource;
        }
        private void RemoveRow(int count = 1)
        {
            int[,] newSource = new int[RowCount - count, ColumnCount];
            for (int rowIndex = 0; rowIndex < newSource.GetLength(0); rowIndex++)
                for (int columnIndex = 0; columnIndex < newSource.GetLength(1); columnIndex++)
                    newSource[rowIndex, columnIndex] = dataSource[rowIndex, columnIndex];
            dataSource = newSource;
        }
        private void AddColumn(int count = 1)
        {
            int[,] newSource = new int[RowCount, ColumnCount + count];
            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
                for (int columnIndex = 0; columnIndex < ColumnCount; columnIndex++)
                    newSource[rowIndex, columnIndex] = dataSource[rowIndex, columnIndex];
            dataSource = newSource;
        } 
        private void RemoveColumn(int count = 1)
        {
            int[,] newSource = new int[RowCount, ColumnCount - count];
            for (int rowIndex = 0; rowIndex < newSource.GetLength(0); rowIndex++)
                for (int columnIndex = 0; columnIndex < newSource.GetLength(1); columnIndex++)
                    newSource[rowIndex, columnIndex] = dataSource[rowIndex, columnIndex];
            dataSource = newSource;
        }
        
        private void AddRowInView(int count = 1)
        {
            while (count > 0)
            {
                count--;
                int existingRowCount = matrixRepresentationContainer.Controls.Count;
                RowLayoutPanel newRowView = CreateRow(ColumnCount, existingRowCount);
                for (int columnIndex = 0; columnIndex < ColumnCount; columnIndex++)
                    newRowView.Controls.Add(CreateCell(newRowView.Index, columnIndex));
                matrixRepresentationContainer.Controls.Add(newRowView);
            }
        }
        private void RemoveRowInView(int count = 1)
        {
            while (count > 0)
            {
                count--;
                if (matrixRepresentationContainer.Controls.Count > 0)
                    matrixRepresentationContainer.Controls.RemoveAt(matrixRepresentationContainer.Controls.Count - 1);
                else if (matrixRepresentationContainer.Controls.Count == 0)
                    matrixRepresentationContainer.Controls.RemoveAt(matrixRepresentationContainer.Controls.Count);
            }
        }
        private void AddColumnInView(int count = 1)
        {
            for (int rowIndex = 0; rowIndex < matrixRepresentationContainer.Controls.Count; rowIndex++)
            {
                int currentCount = count;
                RowLayoutPanel rowView = (RowLayoutPanel)(matrixRepresentationContainer.Controls[rowIndex]);
                while (currentCount > 0)
                {
                    currentCount--;
                    rowView.Controls.Add(CreateCell(rowIndex, rowView.ColumnCount));
                    rowView.ColumnCount++;
                }
            }
        }
        private void RemoveColumnInView(int count = 1)
        {
            foreach (RowLayoutPanel rowView in matrixRepresentationContainer.Controls)
            {
                int currentCount = count;
                while (currentCount > 0)
                {
                    currentCount--;
                    rowView.ColumnCount--;
                    if (rowView.Controls.Count > 0)
                        rowView.Controls.RemoveAt(rowView.Controls.Count - 1);
                    else if (rowView.Controls.Count == 0)
                        rowView.Controls.RemoveAt(rowView.Controls.Count);
                }
            }
        }

        private CellTextBox CreateCell(int rowIndex, int columnindex)
        {
            bool isSelected = false;
            CellTextBox cellBox = new CellTextBox(isSelected: isSelected);
            cellBox.Name = $"matrixCellTextBox{rowIndex + columnindex}";
            cellBox.RowIndex= rowIndex;
            cellBox.ColumnIndex= columnindex;
            if(rowIndex < DataSource.GetLength(0) &&
                columnindex < DataSource.GetLength(1))
            cellBox.Text = DataSource[rowIndex, columnindex].ToString();
            cellBox.Validated += CellBox_Validated;
            cellBox.ReadOnly = this.ReadOnly;
            return cellBox;
        }
        private RowLayoutPanel CreateRow(int cellCount = 0, int rowIndex = 0)
        {
            RowLayoutPanel tableLayoutPanel = new RowLayoutPanel();
            tableLayoutPanel.ColumnCount = cellCount;
            for (int cellIndex = 0; cellIndex < cellCount; cellIndex++)
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel.Name = $"matrixRowContainer{rowIndex}";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.Index= rowIndex;

            return tableLayoutPanel;
        }

        private void Rebuild()
        {
            DateTime startTime= DateTime.Now;
            SuspendDrawing(matrixRepresentationContainer);
            SuspendLayout();
            matrixRepresentationContainer.Controls.Clear();

            if (matrixRepresentationContainer.Controls.Count > 0)
            {

                int existingColumnCount = ((RowLayoutPanel)matrixRepresentationContainer.Controls[0]).ColumnCount;
                if (existingColumnCount > 0)
                {
                    int columnToAdd = ColumnCount - existingColumnCount;
                    if (columnToAdd > 0)
                        AddColumnInView(Math.Abs(columnToAdd));
                    else if (columnToAdd < 0)
                        RemoveColumnInView(Math.Abs(columnToAdd));
                }
                int rowsToAdd = RowCount - matrixRepresentationContainer.Controls.Count;
                if (rowsToAdd > 0)
                    AddRowInView(Math.Abs(rowsToAdd));
                else if (rowsToAdd < 0)
                    RemoveRowInView(Math.Abs(rowsToAdd));
            }
            else if (matrixRepresentationContainer.Controls.Count == 0)
                AddRowInView(RowCount);

            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
                foreach (RowLayoutPanel candidat in matrixRepresentationContainer.Controls)
                {
                    if (candidat.Index == rowIndex)
                    {
                        for (int columnindex = 0; columnindex < ColumnCount; columnindex++)
                        {
                            foreach (CellTextBox cellCandidat in candidat.Controls)
                                if (cellCandidat.ColumnIndex == columnindex)
                                {
                                    if (cellCandidat.Text != dataSource[rowIndex, columnindex].ToString())
                                    {
                                        cellCandidat.Text = dataSource[rowIndex, columnindex].ToString();
                                    }
                                    //TODO(wwaffe): refactor color change algorythm
                                    if (SelectedCells.Any(cell => cell.RowIndex == cellCandidat.RowIndex && cell.ColumnIndex == cellCandidat.ColumnIndex))
                                    {
                                        if (cellCandidat.IsSelected == false)
                                        {
                                            cellCandidat.IsSelected = true;
                                            cellCandidat.BackColor = cellCandidat.SelectedColor;
                                        }
                                    }
                                    else
                                    {
                                        cellCandidat.IsSelected = false;
                                        cellCandidat.BackColor = matrixRepresentationContainer.BackColor;
                                    }
                                    break;
                                }
                        }
                    }
                }

            ResumeLayout();
            PerformLayout();
            ResumeDrawing(matrixRepresentationContainer);
            DateTime endTime = DateTime.Now;
            TimeSpan timeElapsed = endTime - startTime;
            double millis = timeElapsed.TotalMilliseconds;
            Debug.WriteLine($"Draw time for \"{this.Name}\": {millis} ms.");
        }

        private void PaintCriticalPath()
        {
            foreach(Control row in matrixRepresentationContainer.Controls)
            {
                foreach(CellTextBox cellControl in row.Controls)
                {
                    if (SelectedCells.Any(cell => cell.ColumnIndex == cellControl.ColumnIndex && cell.RowIndex == cellControl.RowIndex))
                        cellControl.BackColor = cellControl.SelectedColor;
                    else
                        cellControl.BackColor = cellControl.Parent.BackColor;
                }
            }
        }

        private void CellBox_Validated(object sender, CellEventArgs args)
        {
            if (dataSource.GetLength(0) >= args.RowIndex && dataSource.GetLength(1) >= args.ColumnIndex)
            {
                if (string.IsNullOrEmpty(args.NewValue))
                    dataSource[args.RowIndex, args.ColumnIndex] = 0;
                else
                    dataSource[args.RowIndex, args.ColumnIndex] = int.Parse(args.NewValue);
                OnPropertyChanged(nameof(DataSource));
                DataSourceChanged?.Invoke(dataSource);
            }
        }

        private bool IsIdentical(ref int[,] source, ref int[,] target)
        {
            if (source.GetLength(0) != target.GetLength(0) ||
                source.GetLength(1) != target.GetLength(1))
                return false;
            for (int rowIndex = 0; rowIndex < source.GetLength(0); rowIndex++)
                for (int columnIndex = 0; columnIndex < source.GetLength(1); columnIndex++)
                    if (source[rowIndex, columnIndex] != target[rowIndex, columnIndex])
                        return false;
            return true;
        }

        #region INotify... implementation
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

        private const int WM_SETREDRAW = 11;

        public static void SuspendDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, false, 0);
        }

        public static void ResumeDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, true, 0);
            parent.Refresh();
        }
    }
}