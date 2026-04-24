using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace ArkitektApp;

public class etlProcess
{
  public Sales MapLineToSales(string line)
    {
       String[] dele = line.Split(';');

       Sales nytSalg = new Sales
       {

       Name = dele[0],
       Description = dele[1],
       Quantity = int.Parse(dele[2]),
       Weight = double.Parse(dele[3], CultureInfo.InvariantCulture),
       Height = double.Parse(dele[4], CultureInfo.InvariantCulture),
       Width = double.Parse(dele[5], CultureInfo.InvariantCulture)
       };

        return nytSalg;
    }
    
    public LagerVare MapTilLagerVare(string line)
  {
    string[] dele = line.Split(',');
    
    var vare = new LagerVare
    {
      Navn = dele[0].Trim(),
      Pris = double.Parse(dele[1].Trim(), CultureInfo.InvariantCulture),
      Antal = int.Parse(dele[2].Trim(), CultureInfo.InvariantCulture),
      ErAktiv = bool.Parse(dele[3].Trim())
    };

    return vare;

  }
};