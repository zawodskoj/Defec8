using System;

namespace Defec8.Instructions
{
    public class Fmovi : Instruction
    {
        static Fmovi() => RegisterInstruction<Fmovi>();

        public CpuRegister Target { get; }
        public uint Value { get; }

        public Fmovi(CpuRegister target, uint value)
        {
            Target = target;
            Value = ((float)value).ToUint();
        }

        public override void Execute(Cpu cpu)
        {
            cpu.SetRegister(Target, Value);
        }
    }

    public class Fmovfr : Instruction
    {
        static Fmovfr() => RegisterInstruction<Fmovfr>();

        public CpuRegister To { get; }
        public CpuRegister From { get; }

        public Fmovfr(CpuRegister to, CpuRegister from)
        {
            To = to;
            From = from;
        }

        public override void Execute(Cpu cpu)
        {
            cpu.SetRegister(To, (uint)(int)cpu.GetRegister(From).ToSingle());
        }
    }


    public class Fmovrf : Instruction
    {
        static Fmovrf() => RegisterInstruction<Fmovrf>();

        public CpuRegister To { get; }
        public CpuRegister From { get; }

        public Fmovrf(CpuRegister to, CpuRegister from)
        {
            To = to;
            From = from;
        }

        public override void Execute(Cpu cpu)
        {
            cpu.SetRegister(To, ((float)(int)cpu.GetRegister(From)).ToUint());
        }
    }

    public class Fadd : Instruction
    {
        static Fadd() => RegisterInstruction<Fadd>();

        public CpuRegister To { get; }
        public CpuRegister From { get; }

        public Fadd(CpuRegister to, CpuRegister from)
        {
            To = to;
            From = from;
        }

        public override void Execute(Cpu cpu)
        {
            cpu.SetRegister(To,
                (cpu.GetRegister(To).ToSingle() + cpu.GetRegister(From).ToSingle()).ToUint());
        }
    }

    public class Fsub : Instruction
    {
        static Fsub() => RegisterInstruction<Fsub>();

        public CpuRegister To { get; }
        public CpuRegister From { get; }

        public Fsub(CpuRegister to, CpuRegister from)
        {
            To = to;
            From = from;
        }

        public override void Execute(Cpu cpu)
        {
            cpu.SetRegister(To,
                (cpu.GetRegister(To).ToSingle() - cpu.GetRegister(From).ToSingle()).ToUint());
        }
    }

    public class Fmul : Instruction
    {
        static Fmul() => RegisterInstruction<Fmul>();

        public CpuRegister To { get; }
        public CpuRegister From { get; }

        public Fmul(CpuRegister to, CpuRegister from)
        {
            To = to;
            From = from;
        }

        public override void Execute(Cpu cpu)
        {
            cpu.SetRegister(To,
                (cpu.GetRegister(To).ToSingle() * cpu.GetRegister(From).ToSingle()).ToUint());
        }
    }

    public class Fdiv : Instruction
    {
        static Fdiv() => RegisterInstruction<Fdiv>();

        public CpuRegister To { get; }
        public CpuRegister From { get; }

        public Fdiv(CpuRegister to, CpuRegister from)
        {
            To = to;
            From = from;
        }

        public override void Execute(Cpu cpu)
        {
            cpu.SetRegister(To,
                (cpu.GetRegister(To).ToSingle() / cpu.GetRegister(From).ToSingle()).ToUint());
        }
    }

    public static class NumberHelpers
    {
        public static uint ToUint(this float value)
            => BitConverter.ToUInt32(BitConverter.GetBytes(value), 0);

        public static float ToSingle(this uint value)
            => BitConverter.ToSingle(BitConverter.GetBytes(value), 0);
    }
}
