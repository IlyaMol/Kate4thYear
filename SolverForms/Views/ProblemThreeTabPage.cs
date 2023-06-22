using SolverForms.Views.ViewModels;

namespace SolverForms.Views
{
    public partial class ProblemThreeTabPage : TabPage
    {
        private ProblemThreeViewModel viewModel;

        public ProblemThreeTabPage()
        {
            viewModel = new ProblemThreeViewModel();

            InitializeComponent();
            UpdateDataBindings();

            sourceQueueTextBox.DataSourceChanged += SourceQueueTextBox_DataSourceChanged;
        }

        private void SourceQueueTextBox_DataSourceChanged(double[] newDataSource)
        {
            viewModel.SourceQueue = newDataSource;
        }

        public void UpdateDataBindings()
        {
            sourceQueueTextBox.DataBindings.Add
                (
                nameof(sourceQueueTextBox.DataSource),
                viewModel,
                nameof(viewModel.SourceQueue),
                false,
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
            processUpDown.DataBindings.Add
                (
                nameof(processUpDown.Value),
                viewModel,
                nameof(viewModel.ProcessCount),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
            copyUpDown.DataBindings.Add
                (
                nameof(copyUpDown.Value),
                viewModel,
                nameof(viewModel.CopyValue),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
            minimumExecTimeValue.DataBindings.Add
                (
                nameof(minimumExecTimeValue.Text),
                viewModel,
                nameof(viewModel.MinimalExecutionTimeLabelValue), 
                true,
                DataSourceUpdateMode.OnPropertyChanged
                ); 
            requiredProcessorCountValue.DataBindings.Add
                (
                nameof(requiredProcessorCountValue.Text),
                viewModel,
                nameof(viewModel.RequiredProcessorCountLabelValue)
                );
            minimumProcessorCountValue.DataBindings.Add
                (
                nameof(minimumProcessorCountValue.Text),
                viewModel,
                nameof(viewModel.MinimumProcessorCountLabelValue),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
        }
    }
}
