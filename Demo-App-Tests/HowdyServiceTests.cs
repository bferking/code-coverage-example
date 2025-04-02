using Demo_App;

namespace Demo_App_Tests;

public class HowdyServiceTests
{
    [Fact]
    public void Howdy_Test()
    {
        // Arrange
        var howdyService = new HowdyService();
        // Act
        var result = howdyService.Howdy("UNIT TEST");
        // Assert
        Assert.Equal("Howdy UNIT TEST", result);
    }
}