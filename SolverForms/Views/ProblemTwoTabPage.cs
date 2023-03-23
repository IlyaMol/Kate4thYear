using SolverForms.Views.ViewModels;

namespace SolverForms.Views
{
    public partial class ProblemTwoTabPage : Form
    {
        private ProblemTwoViewModel viewModel;
        
        public ProblemTwoTabPage()
        {
            viewModel = new ProblemTwoViewModel();
            InitializeComponent();
        }

        public void DataBindings()
        {
            processorUpDown.DataBindings.Add
                (
                nameof(processorUpDown.Value),
                viewModel,
                nameof(viewModel.ProcessorCount),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
            processUpDown.DataBindings.Add
                (
                nameof(processUpDown.Value),
                viewModel,
                nameof(viewModel.ProcessCount),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
            processorUpDown.DataBindings.Add
                (
                nameof(processorUpDown.Value),
                viewModel,
                nameof(viewModel.ProcessorCount),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
        }
    }
}