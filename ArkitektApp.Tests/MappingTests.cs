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

    [Fact]
public void MapTilLagerVare_SkalKunneLaeseKommaOgBool()
    {
        var etl = new etlProcess();
        string rawData = "Skruetrækker, 45.40, 15, true";

        var resultat = etl.MapTilLagerVare(rawData);

        Assert.Equal("Skruetrækker", resultat.Navn);
        Assert.Equal(45.40, resultat.Pris);
        Assert.Equal(15, resultat.Antal);
        Assert.True(resultat.ErAktiv);
    }
}