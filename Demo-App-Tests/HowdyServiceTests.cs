using Demo_App;

namespace Demo_App_Tests;

public class HowdyServiceTests : IDisposable
{
    private readonly HowdyService _howdyService;

    public HowdyServiceTests()
    {
        _howdyService = new HowdyService();
    }

    public void Dispose()
    {
        
    }

    [Fact]
    public void Howdy_Test()
    {
        // Act
        var result = _howdyService.Howdy("UNIT TEST");
        // Assert
        Assert.Equal("Howdy UNIT TEST", result);
   }

    [Fact]
    public void Howdy_Hola_Test()
    {
        var result = _howdyService.Hola("UNIT TEST");
        Assert.Equal("Hola UNIT TEST", result);
    }
}