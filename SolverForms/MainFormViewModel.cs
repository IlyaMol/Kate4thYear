﻿using ProblemOne.Model;
using SolverForms.Controls;
using SolverForms.DrawLib;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SolverForms
{
    public class MainFormViewModel : INotifyPropertyChanged
    {
        #region Fields
        private bool isNotBusy = true;
        private int processorCount = 0;
        private int[,] sourceMatrix = new int[0, 0];
        private int[,] resultMatrix = new int[0, 0];
        private int criticalPathLength = 0;
        private int selectedCriticalPathIndex = 1;
        private List<List<KVertex>> criticalPaths = new();
        private List<KVertex> selectedCriticalPath = new();
        private KGraph? graph;
        #endregion

        #region Properties
        public bool IsNotBusy
        {
            get { return isNotBusy; }
            set
            {
                if (isNotBusy == value) return;
                isNotBusy = value;
                OnPropertyChanged();
            }
        }

        public int CriticalPathCount
        {
            get
            {
                return criticalPaths.Count;
            }
        }
        public int SelectedCriticalPathIndex
        {
            get { return selectedCriticalPathIndex; }
            set
            {
                if (selectedCriticalPathIndex == value) return;
                selectedCriticalPathIndex= value;
                RedrawGraphics();
                OnPropertyChanged();
            }
        }

        public int ProcessorCount
        {
            get { return processorCount; }
            set
            {
                if (processorCount == value) return;
                processorCount = value;
                RecalcResult();
                OnPropertyChanged();
            }
        }
        public int ProcessCount
        {
            get { return sourceMatrix.GetLength(0); }
        }
        public int BlockCount
        {
            get { return sourceMatrix.GetLength(1); }
        }
        public int[,] SourceMatrix
        {
            get { return sourceMatrix; }
            set
            {
                if (sourceMatrix == value) return;
                sourceMatrix = value;
                OnPropertyChanged();
            }
        }
        public int[,] ResultMatrix
        {
            get { return resultMatrix; }
            set
            {
                if (resultMatrix == value) return;
                resultMatrix = value;
                OnPropertyChanged();
            }
        }
        public int CriticalPathLength
        {
            get { return criticalPathLength; }
            set
            {
                if(criticalPathLength == value) return;
                criticalPathLength = value;
                OnPropertyChanged();
            }
        }
        public List<Coordinates> CriticalPath
        {
            get
            {
                List<Coordinates> result = new List<Coordinates>();
                foreach (KVertex vertex in selectedCriticalPath)
                    result.Add(new Coordinates() { RowIndex = vertex.RowIndex, ColumnIndex = vertex.ColumnIndex});
                return result;
            }
        }
        #endregion

        public delegate void UpdateFrameDelegate(ICollection<KGLine> scene);
        public event UpdateFrameDelegate OnFrameUpdate;

        public float CurrentSceneWidth { get; set; }
        public float CurrentSceneHeight { get; set; }

        public Dictionary<int, int[,]>? SubProcess { get; private set; }

        #region Methods
        public void DataSourceChangedDelegate(int[,] newDataSource)
        {
            SourceMatrix = newDataSource;

            int[,] tmpMatr = new int[newDataSource.GetLength(0), newDataSource.GetLength(1)];
            Array.Copy(newDataSource, 0, tmpMatr, 0, newDataSource.Length);

            RecalcResult();
        }

        public void RecalcResult()
        {
            if (IsNotBusy) IsNotBusy = false;
            SelectedCriticalPathIndex = 1;
            SubProcess = KGraph.GetSubProcesses(SourceMatrix, processorCount);
            int[,] preparedMatrix = KGraph.PrepareMatrix(SourceMatrix, processorCount);
            ResultMatrix = preparedMatrix;

            if(KGraph.TryBuid(preparedMatrix, out graph))
            {
                criticalPaths = graph.GetCriticalPath();
            }
            RedrawGraphics();
        }

        public void RedrawGraphics()
        {
            if (IsNotBusy) IsNotBusy = false;
            if (graph == null)
            {
                if (!IsNotBusy) IsNotBusy = true;
                return;
            }
            if (criticalPaths.Count > 0 && selectedCriticalPathIndex > 0)
                selectedCriticalPath = criticalPaths[selectedCriticalPathIndex - 1];
            CriticalPathLength = selectedCriticalPath.Sum(v => v.Weight);

            // TODO(wwaffe): here start of test graphics code
            SceneGenerator generator = new(CurrentSceneWidth, CurrentSceneHeight) { CoordPadding = new Padding(20) };
            ICollection<KGLine> scene = generator.GetCoordPlane(ProcessorCount);
            OnFrameUpdate?.Invoke(scene);
            //end draw algo
            if (!IsNotBusy) IsNotBusy = true;
        }
        #endregion

        #region INotify... implementation
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}