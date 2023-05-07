using System.ComponentModel;

namespace ProblemOne
{
    public enum EProcType
    {
        None = 0,
        Async = 1,
        SyncFirst = 2,
        SyncSecond = 3
    }

    public class KProcType
    {
        public string Name { get; set; } = "";
        public EProcType Type { get; set; } = EProcType.None;
    }
}
