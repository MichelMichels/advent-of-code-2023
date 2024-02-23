namespace AoC.Day1.Tests;

[TestClass()]
public class TrebuchetCalibratorTests
{
    [TestMethod()]
    public void FileExists()
    {
        // Arrange
        string filePath = "example.txt";

        // Act

        // Assert
        Assert.IsTrue(File.Exists(filePath));
    }

    [TestMethod]
    public void ExampleTest()
    {
        // Arrange
        TrebuchetCalibrator trebuchetCalibrator = new();

        // Act
        int result = trebuchetCalibrator.Calculate(File.ReadAllText("example.txt"));

        // Assert
        Assert.AreEqual(142, result);
    }
}