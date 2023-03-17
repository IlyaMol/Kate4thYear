using System.Runtime.InteropServices;

namespace SolverForms.Helpers
{
    public class ByteSerializer
    {
        internal static StructureType ReadStructure<StructureType>(Stream Stream)
            where StructureType : struct
        {
            int Length = Marshal.SizeOf(typeof(StructureType));
            byte[] Bytes = new byte[Length];
            Stream.Read(Bytes, 0, Length);
            IntPtr Handle = Marshal.AllocHGlobal(Length);
            Marshal.Copy(Bytes, 0, Handle, Length);
            StructureType Result = (StructureType)Marshal.PtrToStructure(Handle, typeof(StructureType));
            Marshal.FreeHGlobal(Handle);
            return Result;
        }

        internal static void WriteStructure(object Structure, Stream Stream)
        {
            int Length = Marshal.SizeOf(Structure);
            byte[] Bytes = new byte[Length];
            IntPtr Handle = Marshal.AllocHGlobal(Length);
            Marshal.StructureToPtr(Structure, Handle, false);
            Marshal.Copy(Handle, Bytes, 0, Length);
            Marshal.FreeHGlobal(Handle);
            Stream.Write(Bytes, 0, Length);
        }
    }
}
