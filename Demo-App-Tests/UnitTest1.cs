using Demo_App;

namespace Demo_App_Tests;

public class UnitTest1
{
   [Fact]
    public void NoArguments_Test()
    {
        // Arrange
        var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        Program.Main([]);

        // Assert
        var output = writer.GetStringBuilder().ToString().Trim();
        Assert.Equal($"Hello there!{Environment.NewLine}{Environment.NewLine}Complete", output);
    }

    [Fact]
    public void OneArguments_Test()
    {
        // Arrange
        var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        Program.Main(["UNIT TEST"]);

        // Assert
        var output = writer.GetStringBuilder().ToString().Trim();
        Assert.Equal($"Howdy, UNIT TEST!{Environment.NewLine}{Environment.NewLine}Complete", output);
    }
}