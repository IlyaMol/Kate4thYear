using System.Diagnostics;

namespace SolverForms
{
    public partial class MainForm : Form
    {
        private MainFormViewModel viewModel;
        public MainForm()
        {
            viewModel = new MainFormViewModel();
            InitializeComponent();

            sourceMatrixView.SuspendLayout();
            resultMatrixView.SuspendLayout();

            sourceMatrixView.AutoSize = true;
            sourceMatrixView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            resultMatrixView.AutoSize = true;
            resultMatrixView.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            resultMatrixView.ResumeLayout();
            resultMatrixView.PerformLayout();
            sourceMatrixView.ResumeLayout();
            sourceMatrixView.PerformLayout();

            sourceMatrixView.DataSourceChanged += viewModel.DataSourceChangedDelegate;
            UpdateDataBindings();
        }

        private void UpdateDataBindings()
        {
            sourceMatrixView.DataBindings.Add
                (
                    nameof(sourceMatrixView.DataSource),
                    viewModel,
                    nameof(viewModel.SourceMatrix),
                    false,
                    DataSourceUpdateMode.OnPropertyChanged
                );
            resultMatrixView.DataBindings.Add
                (
                nameof(resultMatrixView.DataSource),
                viewModel,
                nameof(viewModel.ResultMatrix),
                false,
                DataSourceUpdateMode.OnPropertyChanged
                );
            resultMatrixView.DataBindings.Add
                (
                nameof(resultMatrixView.SelectedCells),
                viewModel,
                nameof(viewModel.SelectedCriticalPath)
                );
            processUpDown.DataBindings.Add
                (
                nameof(processUpDown.Value),
                viewModel,
                nameof(viewModel.ProcessorCount),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
            selectedPathIndexUpDown.DataBindings.Add
                (
                nameof(selectedPathIndexUpDown.Value),
                viewModel,
                nameof(viewModel.SelectedCriticalPathIndex),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
            selectedPathIndexUpDown.DataBindings.Add
                (
                nameof(selectedPathIndexUpDown.Maximum),
                viewModel,
                nameof(viewModel.CriticalPathCount),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
            progressBar1.DataBindings.Add
                (
                nameof(progressBar1.Visible),
                viewModel,
                nameof(viewModel.IsBusy)
                );
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            viewModel.ProcessorCount = 3;
            viewModel.SourceMatrix = new[,]
            {
                { 1,2,3,1 },
                { 2,3,1,2 },
                { 3,1,2,1 },
                { 1,2,1,1 },
                { 2,1,1,2 },
                { 2,1,3,1 },
                { 3,2,1,1 },
                { 1,1,3,2 },
                { 2,1,2,3 },
            };
        }
    }
}
