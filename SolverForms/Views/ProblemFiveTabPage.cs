using SolverForms.Views.ViewModels;

namespace SolverForms.Views
{
    public partial class ProblemFiveTabPage : TabPage
    {
        private ProblemFiveViewModel viewModel;

        public ProblemFiveTabPage()
        {
            InitializeComponent();

            viewModel = new ProblemFiveViewModel();
            UpdateDataBindings();

            //eValUpDown.DecimalPlaces= 1;
        }

        public void UpdateDataBindings()
        {
            resultALabelValue.DataBindings.Add
                (
                nameof(resultALabelValue.Text),
                viewModel,
                nameof(viewModel.ProcessReqACountLabel),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
            resultBLabelValue.DataBindings.Add
                (
                nameof(resultBLabelValue.Text),
                viewModel,
                nameof(viewModel.ProcessReqBCountLabel),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
            resultCLabelValue.DataBindings.Add
                (
                nameof(resultCLabelValue.Text),
                viewModel,
                nameof(viewModel.ProcessReqCCountLabel),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
        }
    }
}
