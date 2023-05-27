using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace SolverForms.Views.Controls
{
    public partial class QueueTextBox : TextBox, INotifyPropertyChanged
    {
        private double[] _dataSource = Array.Empty<double>();
        public double[] DataSource
        {
            get { return _dataSource; }
            set 
            {
                _dataSource = value;
                OnPropertyChanged();
                OnDataSourceChanged(_dataSource);
            }
        }

        public delegate void DataSourceChangedDelegate(double[] newDataSource);
        public event DataSourceChangedDelegate? DataSourceChanged;

        public QueueTextBox() : base()
        {
            InitializeComponent();
            this.SuspendLayout();
            base.KeyPress += QueueTextBox_KeyPress;
            base.Validating += QueueTextBox_Validating;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public void OnDataSourceChanged(double[] newDataSource)
        {
            string newText = string.Join(",",
                        newDataSource.Select(r => r.ToString(CultureInfo.InvariantCulture)));
            this.Text = newText;
            DataSourceChanged?.Invoke(newDataSource);
        }

        private void QueueTextBox_Validating(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            NumberStyles styles = NumberStyles.AllowParentheses | NumberStyles.AllowTrailingSign | NumberStyles.Float;

            string queueString = ((QueueTextBox)sender!).Text;
            if (string.IsNullOrWhiteSpace(queueString)) return;

            if (queueString.EndsWith(','))
                queueString = queueString.Remove(queueString.LastIndexOf(','));

            string[] substrings = queueString.Split(',');
            double[] newSourceData = new double[substrings.Length];
            for(int substringIndex = 0; substringIndex < substrings.Length; substringIndex++)
            {
                double nextItem = -1;
                if (double.TryParse(substrings[substringIndex], styles, CultureInfo.InvariantCulture, out nextItem))
                    newSourceData[substringIndex] = nextItem;
            }

            DataSource = newSourceData;
        }

        private void QueueTextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !e.KeyChar.Equals(',') && !e.KeyChar.Equals('.'))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar.Equals(','))
            {
                if (((QueueTextBox)sender!).Text.Length == 0 
                    || !char.IsDigit(((QueueTextBox)sender!).Text.Last()))
                    e.Handled = true;
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
