﻿using ProblemOne;
using SolverForms.DrawLib;
using SolverForms.Helpers;
using SolverForms.Views.ViewModels;

namespace SolverForms.Views
{
    public partial class ProblemOneTabPage : TabPage
    {
        private ProblemOneViewModel viewModel;

        public ProblemOneTabPage()
        {
            Name = "инд. 1";
            viewModel = new ProblemOneViewModel();
            InitializeComponent();

            sourceMatrixView.SuspendLayout();
            resultMatrixView.SuspendLayout();
            buildCombinedCheckBox.SuspendLayout();

            sourceMatrixView.AutoSize = true;
            sourceMatrixView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            resultMatrixView.AutoSize = true;
            resultMatrixView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            resultMatrixView.ReadOnly= true;
            buildCombinedCheckBox.Checked = true;

            resultMatrixView.ResumeLayout();
            resultMatrixView.PerformLayout();
            sourceMatrixView.ResumeLayout();
            sourceMatrixView.PerformLayout();
            buildCombinedCheckBox.ResumeLayout();
            buildCombinedCheckBox.PerformLayout();
            viewModel.CurrentSceneHeight = drawPanel.Height;
            viewModel.CurrentSceneWidth = drawPanel.Width;

            executeMethodComboBox.DisplayMember = "Name";
            executeMethodComboBox.ValueMember = "Type";

            distributeMethodComboBox.DisplayMember = "Name";
            distributeMethodComboBox.ValueMember = "Type";

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
            executeMethodComboBox.DataBindings.Add
                (
                nameof(executeMethodComboBox.DataSource),
                viewModel,
                nameof(viewModel.ExecuteModeTypes)
                );
            executeMethodComboBox.DataBindings.Add
                (
                nameof(executeMethodComboBox.SelectedValue),
                viewModel,
                nameof(viewModel.SelectedExecuteType),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
            distributeMethodComboBox.DataBindings.Add
                (
                nameof(distributeMethodComboBox.DataSource),
                viewModel,
                nameof(viewModel.DistributionModeTypes)
                );
            distributeMethodComboBox.DataBindings.Add
                (
                nameof(distributeMethodComboBox.SelectedValue),
                viewModel,
                nameof(viewModel.SelectedDistributeType),
                true,
                DataSourceUpdateMode.OnPropertyChanged
                );
        }
        private void SaveDataButton_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                string jsonString = Json.Serialize(new SourceData()
                {
                    BulidCombined = viewModel.BulidCombined,
                    Data = viewModel.SourceMatrix.ToOneDimArray(),
                    DrawingScale = viewModel.DrawingScale,
                    ProcessorCount = viewModel.ProcessorCount,
                    BlockCount = viewModel.SourceMatrix.GetLength(1)
                });
                FileHelper.WriteToFile(jsonString, saveFileDialog1.FileName);
            }
        }
        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                string jsonData = FileHelper.ReadFromFile(openFileDialog1.FileName);
                SourceData? data = Json.Deserialize<SourceData>(jsonData);

                if (data == null) return;

                viewModel.ProcessorCount = data.ProcessorCount;
                viewModel.BulidCombined = data.BulidCombined;
                viewModel.DrawingScale = data.DrawingScale;
                viewModel.SourceMatrix = data.Data.ToTwoDimArray(data.BlockCount);
            }
        }

        private void saveDataButton_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog(this);
            if(result == DialogResult.OK)
            {
                string jsonString = Json.Serialize(new SourceData()
                {
                    BulidCombined = viewModel.BulidCombined,
                    Data = viewModel.SourceMatrix.ToOneDimArray(),
                    DrawingScale = viewModel.DrawingScale,
                    ProcessorCount = viewModel.ProcessorCount,
                    BlockCount = viewModel.SourceMatrix.GetLength(1)
                });
                FileHelper.WriteToFile(jsonString, saveFileDialog1.FileName);
            }
        }
    }
}
