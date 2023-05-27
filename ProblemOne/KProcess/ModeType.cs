using System.ComponentModel;

namespace ProblemOne
{
    public enum EExecuteModeType
    {
        None = 0,
        Async = 1,
        SyncFirst = 2,
        SyncSecond = 3
    }
    public enum EDistributeModeType
    {
        None = 0,
        Centralized = 1,
        Distributed = 2
    }
    public class KExecuteModeType
    {
        public string Name { get; set; } = "";
        public EExecuteModeType Type { get; set; } = EExecuteModeType.None;
    }
    public class KDistributeModeType
    {
        public string Name { get; set; } = "";
        public EDistributeModeType Type { get; set; } = EDistributeModeType.None;
    }
}