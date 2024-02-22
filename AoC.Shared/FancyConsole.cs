namespace AoC.Shared;

public class FancyConsole
{
    public void Write(string message, ConsoleColor? foreground = null, ConsoleColor? background = null)
    {
        SetColors(foreground, background);

        Console.Write(message);
        ResetColors();
    }

    public void WriteLine(string message, ConsoleColor? foreground = null, ConsoleColor? background = null)
    {
        SetColors(foreground, background);
        Console.WriteLine(message);
        ResetColors();
    }

    public void NewLine()
    {
        Console.WriteLine();
    }

    private void SetColors(ConsoleColor? foreground, ConsoleColor? background)
    {
        if (foreground != null)
        {
            Console.ForegroundColor = foreground.Value;
        }

        if (background != null)
        {
            Console.BackgroundColor = background.Value;
        }
    }
    private void ResetColors()
    {
        Console.ResetColor();
    }
}
