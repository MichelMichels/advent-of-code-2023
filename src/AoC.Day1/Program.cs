using AoC.Day1;
using AoC.Shared;

FancyConsole console = new();
TrebuchetCalibrator trebuchetCalibrator = new();

console.WriteLine(" * Advent of Code 2023 * ", ConsoleColor.Red, ConsoleColor.Yellow);
console.NewLine();
console.WriteLine("      ~~~ Day 1 ~~~      ");
console.NewLine();

int result = trebuchetCalibrator.CalculatePartOne(File.ReadAllText("puzzle.txt"));

console.WriteLine($"Result for part 1: {result}", ConsoleColor.Magenta);

