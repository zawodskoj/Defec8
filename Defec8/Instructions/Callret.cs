using System;

namespace Defec8.Instructions
{
    public class Call : Instruction
    {
        static Call() => RegisterInstruction<Call>();

        public uint Ip { get; }

        public Call(uint ip)
        {
            Ip = ip;
        }

        public override void Execute(Cpu cpu)
        {
            var bytes = BitConverter.GetBytes(cpu.RegIp + 1);
            cpu.RegSp += 4;
            cpu.SetMemory(cpu.RegSp, bytes[0]);
            cpu.SetMemory(cpu.RegSp + 1, bytes[1]);
            cpu.SetMemory(cpu.RegSp + 2, bytes[2]);
            cpu.SetMemory(cpu.RegSp + 3, bytes[3]);
            cpu.RegIp = Ip - 1;
        }
    }

    public class Ret : Instruction
    {
        static Ret() => RegisterInstruction<Ret>();
        
        public override void Execute(Cpu cpu)
        {
            var bytes = new[]
            {
                cpu.GetMemory(cpu.RegSp),
                cpu.GetMemory(cpu.RegSp + 1),
                cpu.GetMemory(cpu.RegSp + 2),
                cpu.GetMemory(cpu.RegSp + 3)
            };
            cpu.RegIp = BitConverter.ToUInt32(bytes, 0) - 1;
            cpu.RegSp -= 4;
        }
    }
}
