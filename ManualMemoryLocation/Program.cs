using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ManualMemoryLocation
{
    [StructLayout(LayoutKind.Explicit)]
    struct unionLike
    {
        [FieldOffset(0)]
        public int lg;
        [FieldOffset(0)]
        public short lgf;
        [FieldOffset(2)]
        public short lge;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var i = new unionLike();
            i.lg = 0x12345678;
            Console.WriteLine($"Top 16 bits: {i.lgf:X4}\nRemaining bits: {i.lge:X4}");
        }
    }
}
