using System;

namespace Defec8.Instructions
{
    public class Add : Instruction
    {
        static Add() => RegisterInstruction<Add>();

        public CpuRegister RegTo { get; }
        public CpuRegister RegFrom { get; }

        public Add(CpuRegister regTo, CpuRegister regFrom)
        {
            RegTo = regTo;
            RegFrom = regFrom;
        }

        public override void Execute(Cpu cpu)
        {
            var from = cpu.GetRegister(RegFrom);
            var to = cpu.GetRegister(RegTo);
            ulong result = from + to;

            if (result == 0)
            {
                cpu.SetFlags(CpuFlags.Zero);
            }

            if (result > 0xffffffff)
            {
                cpu.SetFlags(CpuFlags.Overflow);
            }

            cpu.SetRegister(RegTo, (uint)result);
        }
    }

    public class Addi : Instruction
    {
        static Addi() => RegisterInstruction<Addi>();

        public CpuRegister RegTo { get; }
        public uint Value { get; }

        public Addi(CpuRegister regTo, uint value)
        {
            RegTo = regTo;
            Value = value;
        }

        public override void Execute(Cpu cpu)
        {
            var to = cpu.GetRegister(RegTo);
            ulong result = Value + to;

            if (result == 0)
            {
                cpu.SetFlags(CpuFlags.Zero);
            }

            if (result > 0xffffffff)
            {
                cpu.SetFlags(CpuFlags.Overflow);
            }

            cpu.SetRegister(RegTo, (uint)result);
        }
    }

    public class Abs : Instruction
    {
        static Abs() => RegisterInstruction<Abs>();

        public CpuRegister Register { get; }

        public Abs(CpuRegister reg)
        {
            Register = reg;
        }

        public override void Execute(Cpu cpu)
        {
            var result = Math.Abs((long) (int) cpu.GetRegister(Register));

            if (result == 0)
            {
                cpu.SetFlags(CpuFlags.Zero);
            }

            if (result > uint.MaxValue)
            {
                cpu.SetFlags(CpuFlags.Overflow);
            }

            cpu.SetRegister(Register, (uint)result);
        }
    }
}
