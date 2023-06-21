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
            sourceQueueTextBox.DataBindings.Add
                (
                nameof(sourceQueueTextBox.DataSource),
                viewModel,
                nameof(viewModel.SourceQueue),
                false,
                DataSourceUpdateMode.OnPropertyChanged
                );
            uniformQueueTextBox.DataBindings.Add
                (
                nameof(uniformQueueTextBox.DataSource),
                viewModel,
                nameof(viewModel.UniformQueue),
                false,
                DataSourceUpdateMode.OnPropertyChanged
                );
            sqrtnValue.DataBindings.Add
                (
                nameof(sqrtnValue.Text),
                viewModel,
                nameof(viewModel.SqrtNValueLabelText)
                );
            resultTauValueLabel.DataBindings.Add
                (
                nameof(resultTauValueLabel.Text),
                viewModel,
                nameof(viewModel.TauValueLabelText),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
            sumTLabel.DataBindings.Add
                (
                nameof(sumTLabel.Text),
                viewModel,
                nameof(viewModel.SumTValueLabelText)
                );
            optimalBlockCountValueLabel1.DataBindings.Add
                (
                nameof(optimalBlockCountValueLabel1.Text),
                viewModel,
                nameof(viewModel.OptimalBlockCountValueMainLabelText),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
            optimalBlockCountValueLabel2.DataBindings.Add
                (
                nameof(optimalBlockCountValueLabel2.Text),
                viewModel,
                nameof(viewModel.OptimalBlockCountValueSecondaryLabelText),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
            optimalProcessorCountValue.DataBindings.Add
                (
                nameof(optimalProcessorCountValue.Text),
                viewModel,
                nameof(viewModel.OptimalProcessorCountValueText),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
        }
    }
}