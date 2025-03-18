using Demo_App;

namespace Demo_App_Tests;

public class UnitTest1
{
    // Will add back later
    //[Fact]
    //public void NoArguments_Test()
    //{
    //    // Arrange
    //    var writer = new StringWriter();
    //    Console.SetOut(writer);

    //    // Act
    //    Program.Main(Array.Empty<string>());

    //    // Assert
    //    var output = writer.GetStringBuilder().ToString().Trim();
    //    Assert.Equal("Hello!", output);
    //}

    [Fact]
    public void Bad_Test()
    {
        Assert.Equal(true, true);
    }
}