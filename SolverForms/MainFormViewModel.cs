using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SolverForms
{
    public class MainFormViewModel : INotifyPropertyChanged
    {
        public int ProcessorCount
        {
            get;
            set;
        }
        public int ProcessCount
        {
            get; 
            set;
        }
        public int BlockCount
        {
            get; 
            set;
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