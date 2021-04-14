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
            i.lg = 0x11112222;
            Console.WriteLine($"Top 16 bits: {i.lgf:X4}\nLow 16 bits: {i.lge:X4}");
        }
    }
}
