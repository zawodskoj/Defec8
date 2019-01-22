namespace Defec8.Instructions
{
    public class Mov : Instruction
    {
        static Mov() => RegisterInstruction<Mov>();

        public CpuRegister From { get; }
        public CpuRegister To { get; }

        public Mov(CpuRegister from, CpuRegister to)
        {
            From = from;
            To = to;
        }

        public override void Execute(Cpu cpu)
        {
            cpu.SetRegister(To, cpu.GetRegister(From));
        }
    }

    public class Movi : Instruction
    {
        static Movi() => RegisterInstruction<Movi>();

        public CpuRegister Target { get; }
        public uint Value { get; }

        public Movi(CpuRegister target, uint value)
        {
            Target = target;
            Value = value;
        }

        public override void Execute(Cpu cpu)
        {
            cpu.SetRegister(Target, Value);
        }
    }
}
