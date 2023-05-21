using System.Globalization;
using System.Xml;
using Avalonia.Data.Converters;
namespace AppTest.Models;
using System;
using Avalonia.Controls;
using System.Collections.Generic;
using System.Security.Cryptography;
public class Race
{
    public Race(string raceName, int number)
    {
        RaceName = raceName;
    }
    public string RaceName { get; }  

    

    public static Race RacePick()
    {
        var random = new Random(Guid.NewGuid().GetHashCode());
        int generateRace = random.Next(1, 100);
        Race race;

        if (generateRace < 91)
        {
            race = new Race("Human", generateRace);
               
            return race;
        }
        else if (generateRace < 95)
        {
            race = new Race("Halfling", generateRace);
            return race;
        }
        else if (generateRace < 99)
        {
            race = new Race("Dwarf", generateRace);
            return race;
        }
        else if (generateRace == 100)
        {
            race = new Race("HighElf", generateRace);
            return race;
        }
        else 
        {
            race = new Race("WoodElf", generateRace);
            return race;
        }
    }
}
