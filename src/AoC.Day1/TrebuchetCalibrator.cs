namespace AoC.Day1;

public class TrebuchetCalibrator
{
    public int Calculate(string text)
    {
        Span<string> lines = text.Split(Environment.NewLine);

        int result = 0;
        foreach (string line in lines)
        {
            result += int.Parse($"{line.First(x => Char.IsDigit(x))}{line.Reverse().First(x => Char.IsDigit(x))}");
        }

        return result;
    }
}
