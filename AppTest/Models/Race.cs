using System.Globalization;
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
        GeneratedNumber = number;
    }
    public string RaceName { get; set; }
    public int GeneratedNumber { get; set; }
    
    public static int GenerateRace => RandomGenerator.RandomNumber(0, 99);

    public static Race RacePick()
    {
        Race race;

        if (GenerateRace < 91)
        {
            race = new Race("Human", GenerateRace);
               
            return race;
        }
        else if (GenerateRace < 95)
        {
            race = new Race("Halfling", GenerateRace);
            return race;
        }
        else if (GenerateRace < 99)
        {
            race = new Race("Dwarf", GenerateRace);
            return race;
        }
        else if (GenerateRace < 100)
        {
            race = new Race("HighElf", GenerateRace);
            return race;
        }
        else 
        {
            race = new Race("WoodElf", GenerateRace);
            return race;
        }
    }
}

