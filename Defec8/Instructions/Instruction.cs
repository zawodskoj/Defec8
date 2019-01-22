using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Defec8.Instructions
{
    public class CodeParsingResult
    {
        public bool Success { get; set; }
        public string Reason { get; set; }
        public int LineNumber { get; set; }
        public List<(int, Instruction)> Code { get; set; }
    }

    public abstract class Instruction
    {
        public static List<Type> Instructions { get; } = new List<Type>();

        public static void RegisterInstruction<TInstruction>() where TInstruction : Instruction
        {
            // Instructions.Add(typeof(TInstruction));
        }

        public static IEnumerable<string> Opcodes => Instructions.Select(x => x.Name.ToLower());

        public abstract void Execute(Cpu cpu);

        public static CodeParsingResult Parse(string code)
        {
            if (Instructions.Count == 0)
            {
                var derived = from domainAssembly in AppDomain.CurrentDomain.GetAssemblies()
                    from assemblyType in domainAssembly.GetTypes()
                    where typeof(Instruction).IsAssignableFrom(assemblyType)
                    select assemblyType;

                Instructions.AddRange(derived);
            }

            var regs = "ax|bx|cx|ip|si|di|sp|bp";
            var bigRegex = new Regex("^(?:([a-z][a-z0-9]*):\\s*)?(" + string.Join("|", Opcodes) + $@")(?:\s+(\[{regs}\]|{regs}|\d+|0x[0-9a-f]+|[a-z][a-z0-9]*))?(?:\s*,\s*(\[(?:{regs})\]|(?:{regs})|-?\d+|0x[0-9a-f]+|[a-z][a-z0-9]*))?\s*$",
                RegexOptions.IgnoreCase);
            var equRegex = new Regex(@"^([a-z][a-z0-9]*)\s+equ\s+(-?\d+|0x[0-9a-f]+)\s*$",
                RegexOptions.IgnoreCase);

            var instructions = new List<(int, Instruction)>();

            var equs = new Dictionary<string, uint>();

            uint curInst = 0;
            var lineNumber = 0;

            foreach (var (orig, imatch, equmatch) in code.Split(new[] {'\n'})
                .Select(x => (x, bigRegex.Match(x.Trim()), equRegex.Match(x.Trim()))))
            {
                lineNumber++;
                if (string.IsNullOrWhiteSpace(orig)) continue;

                if (!imatch.Success && !equmatch.Success)
                {
                    return new CodeParsingResult
                    {
                        Success = false,
                        Reason = "Ошибка разбора строки:\n\n" + orig,
                        LineNumber = lineNumber - 1
                    };
                }

                if (equmatch.Success)
                {
                    equs.Add(equmatch.Groups[1].Value,
                        equmatch.Groups[2].Value.StartsWith("0x") && uint.TryParse(equmatch.Groups[2].Value.Substring(2), NumberStyles.HexNumber, CultureInfo.InvariantCulture,
                            out var uintRes)
                            ? uintRes
                            : (uint) int.Parse(equmatch.Groups[2].Value));
                }
                else if (!string.IsNullOrEmpty(imatch.Groups[1].Value))
                {
                    equs.Add(imatch.Groups[1].Value, curInst);
                    curInst++;
                }
                else
                    curInst++;
            }
            
            lineNumber = 0;

            foreach (var (orig, match) in code.Split(new[] {'\n'})
                //.Where(x => !string.IsNullOrWhiteSpace(x))
                //.Where(x => !equRegex.IsMatch(x))
                .Select(x => (x, bigRegex.Match(x.Trim()))))
            {
                lineNumber++;

                if (string.IsNullOrWhiteSpace(orig) || equRegex.IsMatch(orig)) continue;
                
                var instruc = Instructions.Single(x => x.Name.ToLower() == match.Groups[2].Value.ToLower());

                try
                {
                    var firstArg =
                        string.IsNullOrWhiteSpace(match.Groups[3].Value)
                            ? null
                            : match.Groups[3].Value.StartsWith("0x") && uint.TryParse(
                                  match.Groups[3].Value.Substring(2), NumberStyles.HexNumber,
                                  CultureInfo.InvariantCulture,
                                  out var uintRes)
                                ? uintRes
                                : int.TryParse(match.Groups[3].Value, out int intRes)
                                    ? (uint) intRes
                                    : equs.ContainsKey(match.Groups[3].Value)
                                        ? equs[match.Groups[3].Value]
                                        : match.Groups[3].Value.StartsWith("[")
                                            ? throw new Exception("UNSUPPORTED")
                                            : Enum.Parse(typeof(CpuRegister), match.Groups[3].Value, true);

                    var secondArg =
                        string.IsNullOrWhiteSpace(match.Groups[4].Value)
                            ? null
                            : match.Groups[4].Value.StartsWith("0x") && uint.TryParse(
                                  match.Groups[4].Value.Substring(2), NumberStyles.HexNumber,
                                  CultureInfo.InvariantCulture,
                                  out uintRes)
                                ? uintRes
                                : int.TryParse(match.Groups[4].Value, out intRes)
                                    ? (uint) intRes
                                    : equs.ContainsKey(match.Groups[4].Value)
                                        ? equs[match.Groups[4].Value]
                                        : match.Groups[4].Value.StartsWith("[")
                                            ? throw new Exception("UNSUPPORTED")
                                            : Enum.Parse(typeof(CpuRegister), match.Groups[4].Value, true);

                    var args = new[] {firstArg, secondArg}.Where(x => x != null).ToArray();

                    instructions.Add((lineNumber - 1, (Instruction) Activator.CreateInstance(instruc, args)));
                }
                catch
                {
                    return new CodeParsingResult
                    {
                        Success = false,
                        Reason = "Ошибка разбора строки:\n\n" + orig,
                        LineNumber = lineNumber - 1
                    };
                }
            }

            return new CodeParsingResult {Code = instructions, Success = true};
        }
    }

    public class Nop : Instruction
    {
        static Nop() => RegisterInstruction<Nop>();

        public override void Execute(Cpu cpu) { }
    }

    public class Hlt : Instruction
    {
        static Hlt() => RegisterInstruction<Hlt>();

        public override void Execute(Cpu cpu) { cpu.Interrupt(CpuInterrupt.Halted); }
    }
}
