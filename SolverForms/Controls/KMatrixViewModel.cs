using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SolverForms.Controls
{
    public class KMatrixViewModel : INotifyPropertyChanged
    {
        private int[,] _matrixStructure = new int[0,0];
        public int[,] MatrixStructure 
        { 
            get { return _matrixStructure; }
            set
            {
                if (value == _matrixStructure) return;
                _matrixStructure= value;
                OnPropertyChanged();
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
