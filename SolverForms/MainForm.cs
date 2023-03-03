using SolverForms.Helpers;
using System.Text;

namespace SolverForms
{
    public partial class MainForm : Form
    {
        public MainFormViewModel ViewModel { get; set; } = new MainFormViewModel();

        public MainForm()
        {
            InitializeComponent();
            CompleteDataBindings();
        }

        private void CompleteDataBindings()
        {
            //processorCountNumUpDownValue.DataBindings.Add("Value", ViewModel, "ProcessorCount", false, DataSourceUpdateMode.OnPropertyChanged);
            processCountNumUpDownValue.DataBindings.Add("Value", kMatrixView1, "RowCount", false, DataSourceUpdateMode.OnPropertyChanged, nullValue: 0); 
            blockCountNumUpDownValue.DataBindings.Add("Value", kMatrixView1, "ColumnCount", false, DataSourceUpdateMode.OnPropertyChanged, nullValue: 0);
        }
    }
}