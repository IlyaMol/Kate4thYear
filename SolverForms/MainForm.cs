﻿using SolverForms.DrawLib;

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
            resultMatrixView.ReadOnly= true;

            resultMatrixView.ResumeLayout();
            resultMatrixView.PerformLayout();
            sourceMatrixView.ResumeLayout();
            sourceMatrixView.PerformLayout();

            viewModel.CurrentSceneHeight = drawPanel.Height;
            viewModel.CurrentSceneWidth = drawPanel.Width;

            sourceMatrixView.DataSourceChanged += viewModel.DataSourceChangedDelegate;
            drawPanel.Resize += DrawPanel_Resize;
            viewModel.OnFrameUpdate += ViewModel_OnFrameUpdate;
            UpdateDataBindings();
        }

        private void DrawPanel_Resize(object? sender, EventArgs e)
        {
            viewModel.CurrentSceneHeight = drawPanel.Height;
            viewModel.CurrentSceneWidth = drawPanel.Width;
        }

        private void ViewModel_OnFrameUpdate(KGScene scene)
        {
            drawPanel.Scene = scene;
            drawPanel.Refresh();
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
                sourceMatrixView,
                nameof(sourceMatrixView.RowCount),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
            blockUpDown.DataBindings.Add
                (
                nameof(blockUpDown.Value),
                sourceMatrixView,
                nameof(sourceMatrixView.ColumnCount),
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
            criticalPathCountValue.DataBindings.Add(
                nameof(criticalPathCountValue.Text),
                viewModel,
                nameof(viewModel.CriticalPathCount)
                );
            criticalPathLengthValue.DataBindings.Add(
                nameof(criticalPathLengthValue.Text),
                viewModel,
                nameof(viewModel.CriticalPathLength)
                );
            buildCombinedCheckBox.DataBindings.Add
                (
                nameof(buildCombinedCheckBox.Checked),
                viewModel,
                nameof(viewModel.BulidCombined),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
            offsetSliderValue.DataBindings.Add
                (
                nameof(offsetSliderValue.Value),
                viewModel,
                nameof(viewModel.DrawingScale),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
        }
        private void LoadDataButton_Click(object sender, EventArgs e)
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

            /*viewModel.ProcessorCount = 3;
            viewModel.SourceMatrix = new[,]
            {
                { 4,2,3 },
                { 1,4,1 },
                { 3,3,2 },
                { 3,1,2 }
            };*/

            /*viewModel.ProcessorCount = 4;
            viewModel.SourceMatrix = new[,]
            {
                { 2,1,4,1 },
                { 1,3,2,3 },
                { 2,4,1,2 },
                { 3,2,3,1 }
            };*/
        }
    }
}
