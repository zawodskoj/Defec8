namespace Defec8.Instructions
{
    public class Jz : Instruction
    {
        static Jz() => RegisterInstruction<Jz>();

        public uint Ip { get; }

        public Jz(uint ip)
        {
            Ip = ip;
        }

        public override void Execute(Cpu cpu)
        {
            if (cpu.FlagZero) cpu.RegIp = Ip - 1;
        }
    }

    public class Jnz : Instruction
    {
        static Jnz() => RegisterInstruction<Jnz>();

        public uint Ip { get; }

        public Jnz(uint ip)
        {
            Ip = ip;
        }

        public override void Execute(Cpu cpu)
        {
            if (!cpu.FlagZero) cpu.RegIp = Ip - 1;
        }
    }
}
