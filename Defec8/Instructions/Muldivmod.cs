namespace Defec8.Instructions
{
    public class Muli : Instruction
    {
        static Muli() => RegisterInstruction<Muli>();

        public CpuRegister RegTo { get; }
        public uint Value { get; }

        public Muli(CpuRegister regTo, uint value)
        {
            RegTo = regTo;
            Value = value;
        }

        public override void Execute(Cpu cpu)
        {
            var to = cpu.GetRegister(RegTo);
            ulong result = to * Value;

            if (result == 0)
            {
                cpu.SetFlags(CpuFlags.Zero);
            }

            if (result > uint.MaxValue)
            {
                cpu.SetFlags(CpuFlags.Overflow);
            }

            cpu.SetRegister(RegTo, (uint)result);
        }
    }

    public class Divi : Instruction
    {
        static Divi() => RegisterInstruction<Divi>();

        public CpuRegister RegTo { get; }
        public uint Value { get; }

        public Divi(CpuRegister regTo, uint value)
        {
            RegTo = regTo;
            Value = value;
        }

        public override void Execute(Cpu cpu)
        {
            var to = cpu.GetRegister(RegTo);
            ulong result = to / Value;

            if (result == 0)
            {
                cpu.SetFlags(CpuFlags.Zero);
            }

            if (result > uint.MaxValue)
            {
                cpu.SetFlags(CpuFlags.Overflow);
            }

            cpu.SetRegister(RegTo, (uint)result);
        }
    }

    public class Modi : Instruction
    {
        static Modi() => RegisterInstruction<Modi>();

        public CpuRegister RegTo { get; }
        public uint Value { get; }

        public Modi(CpuRegister regTo, uint value)
        {
            RegTo = regTo;
            Value = value;
        }

        public override void Execute(Cpu cpu)
        {
            var to = cpu.GetRegister(RegTo);
            ulong result = to % Value;

            if (result == 0)
            {
                cpu.SetFlags(CpuFlags.Zero);
            }

            if (result > uint.MaxValue)
            {
                cpu.SetFlags(CpuFlags.Overflow);
            }

            cpu.SetRegister(RegTo, (uint)result);
        }
    }
}
