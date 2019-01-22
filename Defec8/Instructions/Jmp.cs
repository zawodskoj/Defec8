namespace Defec8.Instructions
{
    public class Jmp : Instruction
    {
        static Jmp() => RegisterInstruction<Jmp>();

        public uint Ip { get; }

        public Jmp(uint ip)
        {
            Ip = ip;
        }

        public override void Execute(Cpu cpu)
        {
            cpu.RegIp = Ip - 1;
        }
    }
}
