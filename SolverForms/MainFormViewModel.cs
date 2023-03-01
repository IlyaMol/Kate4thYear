using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SolverForms
{
    public class MainFormViewModel : INotifyPropertyChanged
    {
        private int     _processorCount;
        private int[,]  _dataSource = new int[4, 4]
        {
            {1,1,1,1},
            {1,1,1,1},
            {1,1,1,1},
            {1,1,1,1}
        };

        public int      ProcessorCount
        {
            get { return _processorCount; }
            set
            {
                if (_processorCount == value) return;
                _processorCount = value;
                OnPropertyChanged();
            }
        }
        public int      ProcessCount
        {
            get { return _dataSource.GetLength(0); }
            set
            {
                if(_dataSource.GetLength(0) == value) return;
                int[,] newArray = new int[value, _dataSource.GetLength(0)];
                DataSource = newArray;
                OnPropertyChanged();
            }
        }
        public int      BlockCount
        {
            get { return _dataSource.GetLength(1); }
            set
            {
                if (_dataSource.GetLength(1) == value) return;
                int[,] newArray = new int[_dataSource.GetLength(0), value];
                DataSource = newArray;
                OnPropertyChanged();
            }
        }
        public int[,]   DataSource
        {
            get { return _dataSource; }
            set
            {
                if (_dataSource == value) return;
                CopyArray(_dataSource, ref value);
                _dataSource = value;
                OnPropertyChanged();
            }
        }

        private void CopyArray(int[,] source, ref int[,] dest)
        {
            for (int rowIndex = 0; rowIndex < dest.GetLength(0); rowIndex++)
            {
                if (rowIndex < source.GetLength(0))
                    for (int columnIndex = 0; columnIndex < dest.GetLength(1); columnIndex++)
                    {
                        if (columnIndex < source.GetLength(1))
                            dest[rowIndex, columnIndex] = source[rowIndex, columnIndex];
                    }
            }
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