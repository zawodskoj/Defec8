using System;

namespace Defec8.Instructions
{
    public class Poked : Instruction
    {
        static Poked() => RegisterInstruction<Poked>();

        public CpuRegister Register { get; }
        public uint Ptr { get; }

        public Poked(CpuRegister register, uint ptr)
        {
            Register = register;
            Ptr = ptr;
        }

        public override void Execute(Cpu cpu)
        {
            var bytes = BitConverter.GetBytes(cpu.GetRegister(Register));
            cpu.SetMemory(Ptr, bytes[0]);
            cpu.SetMemory(Ptr + 1, bytes[1]);
            cpu.SetMemory(Ptr + 2, bytes[2]);
            cpu.SetMemory(Ptr + 3, bytes[3]);
        }
    }

    public class Rpokeb : Instruction
    {
        static Rpokeb() => RegisterInstruction<Rpokeb>();

        public CpuRegister Register { get; }
        public CpuRegister PtrReg { get; }

        public Rpokeb(CpuRegister register, CpuRegister ptrReg)
        {
            Register = register;
            PtrReg = ptrReg;
        }

        public override void Execute(Cpu cpu)
        {
            var bytes = BitConverter.GetBytes(cpu.GetRegister(Register));
            var ptr = cpu.GetRegister(PtrReg);
            cpu.SetMemory(ptr, bytes[0]);
        }
    }

    public class Rpokebi : Instruction
    {
        static Rpokebi() => RegisterInstruction<Rpokebi>();

        public uint Value { get; }
        public CpuRegister PtrReg { get; }

        public Rpokebi(uint value, CpuRegister ptrReg)
        {
            Value = value;
            PtrReg = ptrReg;
        }

        public override void Execute(Cpu cpu)
        {
            var bytes = BitConverter.GetBytes(Value);
            var ptr = cpu.GetRegister(PtrReg);
            cpu.SetMemory(ptr, bytes[0]);
        }
    }
}
