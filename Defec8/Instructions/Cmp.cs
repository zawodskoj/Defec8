namespace Defec8.Instructions
{
    public class Cmp : Instruction
    {
        static Cmp() => RegisterInstruction<Cmp>();

        public CpuRegister Lhs { get; }
        public CpuRegister Rhs { get; }

        public Cmp(CpuRegister lhs, CpuRegister rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public override void Execute(Cpu cpu)
        {
            var lhs = cpu.GetRegister(Lhs);
            var rhs = cpu.GetRegister(Rhs);

            cpu.SetFlags(
                (lhs > rhs ? CpuFlags.Sign : CpuFlags.None) |
                (lhs == rhs ? CpuFlags.Zero : CpuFlags.None));
        }
    }

    public class Cmpi : Instruction
    {
        static Cmpi() => RegisterInstruction<Cmpi>();

        public CpuRegister Lhs { get; }
        public uint Rhs { get; }

        public Cmpi(CpuRegister lhs, uint rhs)
        {
            Lhs = lhs;
            Rhs = rhs;
        }

        public override void Execute(Cpu cpu)
        {
            var lhs = cpu.GetRegister(Lhs);
            var rhs = Rhs;

            cpu.SetFlags(
                (lhs > rhs ? CpuFlags.Sign : CpuFlags.None) |
                (lhs == rhs ? CpuFlags.Zero : CpuFlags.None));
        }
    }
}
