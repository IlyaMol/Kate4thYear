using SolverForms.Views.ViewModels;

namespace SolverForms.Views
{
    public partial class ProblemTwoTabPage : TabPage
    {
        private ProblemTwoViewModel viewModel;
        
        public ProblemTwoTabPage()
        {
            Text = "инд. 2";

            viewModel = new ProblemTwoViewModel();
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
            tauUpDown.DataBindings.Add
                (
                nameof(tauUpDown.Value),
                viewModel,
                nameof(viewModel.TauValue),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
            resultTauLabel.DataBindings.Add
                (
                nameof(resultTauLabel.Text),
                viewModel,
                nameof(viewModel.TauLabelText),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
            resultTauValueLabel.DataBindings.Add
                (
                nameof(resultTauValueLabel.Text),
                viewModel,
                nameof(viewModel.ResultTauValue),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
            optimalBlockCountValueLabel.DataBindings.Add
                (
                nameof(optimalBlockCountValueLabel.Text),
                viewModel,
                nameof(viewModel.OptimalBlockCountValue),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
            sourceQueueTextBox.DataBindings.Add
                (
                nameof(sourceQueueTextBox.DataSource),
                viewModel,
                nameof(viewModel.SourceQueue),
                false,
                DataSourceUpdateMode.OnPropertyChanged
                );
            uniformedQueueTextBox.DataBindings.Add
                (
                nameof(uniformedQueueTextBox.DataSource),
                viewModel,
                nameof(viewModel.UniformQueue),
                false,
                DataSourceUpdateMode.OnPropertyChanged
                );
            optimalProcessorCountValueLabel.DataBindings.Add
                (
                nameof(optimalProcessorCountValueLabel.Text),
                viewModel,
                nameof(viewModel.OptimalProcessorCount),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
        }
    }
}