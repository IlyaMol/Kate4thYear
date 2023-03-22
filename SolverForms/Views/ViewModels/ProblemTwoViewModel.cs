using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SolverForms.Views.ViewModels
{
    public class ProblemTwoViewModel : INotifyPropertyChanged
    {
        #region Fields
        #endregion

        #region Properties
        #endregion

        #region Delegates
        #endregion

        #region Events
        #endregion

        #region Methods
        #endregion

        #region INotify... implementation
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
