namespace CodeWars.CodeWars;

public static class IsSquare
{
    public static bool Execute(int instruction)
    {
        var sqrt = Math.Sqrt(instruction);
        return (sqrt % 1) == 0;
    }
}