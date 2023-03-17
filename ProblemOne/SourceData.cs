using System.Runtime.InteropServices;

namespace ProblemOne
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SourceData
    {
        public int ProcessorCount;
        public bool BulidCombined;
        public float DrawingScale;

        [MarshalAs(UnmanagedType.Array)]
        public int[,] Data;
    }
}
