using System.Text.RegularExpressions;

namespace CodeWars.CodeWars;

public static class SempleAssemblerInterpreter
{
    public static Dictionary<string, int> Interpret(string[] program)
    {

        var result = new Dictionary<string, int>();
        var instructionCounter = 0;

        do
        {
            var instruction = program[instructionCounter].Split(' ');

            if (instruction[0] == "mov")
            {
                if(Int32.TryParse(instruction[2], out int convertedValue))
                {
                    if (!result.ContainsKey(instruction[1]))
                    {
                        result.Add(instruction[1], convertedValue);
                    }
                    else
                    {
                        result[instruction[1]] = convertedValue;
                    }
                }
                else
                {
                    
                    result.TryGetValue(instruction[2], out var value);
                    if (!result.ContainsKey(instruction[1]))
                    {
                        result.Add(instruction[1], value);
                    }
                    else
                    {
                        result[instruction[1]] = value;
                    }
                }
                
                instructionCounter++;
            } else if (instruction[0] == "inc")
            {
                result.TryGetValue(instruction[1], out var value);
                result[instruction[1]] = value + 1;
                instructionCounter++;
            } else if (instruction[0] == "dec")
            {
                result.TryGetValue(instruction[1], out var value);
                result[instruction[1]] = value - 1;
                instructionCounter++;
            }
            else if (instruction[0] == "jnz")
            {
                if (!int.TryParse(instruction[1], out int value))
                {
                    value = result.GetValueOrDefault(instruction[1], 0);
                }
                
                if (!int.TryParse(instruction[2], out int jump))
                {
                    jump = result.GetValueOrDefault(instruction[2], 0);
                }

                if (value != 0)
                    instructionCounter += jump;
                else
                    instructionCounter++;
            }
        }while(instructionCounter < program.Length);

        return result;

    }
    
}