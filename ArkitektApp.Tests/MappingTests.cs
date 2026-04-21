using Xunit;
using ArkitektApp;

namespace ArktitektApp.Tests;

public class MappingTests
{
    [Fact]
    public void MapLineToSales_SkalAfbildeKorrekt()
    {
        var etl = new etlProcess();
        string rawData = "Hammer;En god hammer;10;1.5;0;20.5";

        var resultat = etl.MapLineToSales(rawData);

        Assert.Equal("Hammer", resultat.Name);
        Assert.Equal(10, resultat.Quantity);
        Assert.Equal(20.5, resultat.Width);
    }
}