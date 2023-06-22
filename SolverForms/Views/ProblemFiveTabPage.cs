using SolverForms.Views.ViewModels;

namespace SolverForms.Views
{
    public partial class ProblemFiveTabPage : Form
    {
        private ProblemFiveViewModel viewModel;

        public ProblemFiveTabPage()
        {
            InitializeComponent();

            viewModel = new ProblemFiveViewModel();
            UpdateDataBindings();

            eValUpDown.DecimalPlaces= 1;
        }

        public void UpdateDataBindings()
        {
            processorUpDown.DataBindings.Add
                (
                nameof(processorUpDown.Value),
                viewModel,
                nameof(viewModel.ProcessorCount),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
            blockUpDown.DataBindings.Add
                (
                nameof(blockUpDown.Value),
                viewModel,
                nameof(viewModel.BlockCount),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
            minimalExecTimeValue.DataBindings.Add
                (
                nameof(minimalExecTimeValue.Text),
                viewModel,
                nameof(viewModel.MinExecTime),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
            eValUpDown.DataBindings.Add
                (
                nameof(eValUpDown.Value),
                viewModel,
                nameof(viewModel.eVal),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );

            processReqCountValue.DataBindings.Add
                (
                nameof(processReqCountValue.Text),
                viewModel,
                nameof(viewModel.ProcessReqCount),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
        }
    }
}
