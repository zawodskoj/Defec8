using System;

namespace Defec8.Instructions
{
    public class Peekd : Instruction
    {
        static Peekd() => RegisterInstruction<Peekd>();
        
        public CpuRegister Register { get; }
        public uint Ptr { get; }

        public Peekd(CpuRegister register, uint ptr)
        {
            Register = register;
            Ptr = ptr;
        }

        public override void Execute(Cpu cpu)
        {
            var byte1 = cpu.GetMemory(Ptr);
            var byte2 = cpu.GetMemory(Ptr + 1);
            var byte3 = cpu.GetMemory(Ptr + 2);
            var byte4 = cpu.GetMemory(Ptr + 3);
            cpu.SetRegister(Register, BitConverter.ToUInt32(new[] { byte1, byte2, byte3, byte4 }, 0));
        }
    }
}
