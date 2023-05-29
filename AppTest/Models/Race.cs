namespace AppTest.Models;
using System;
using Avalonia.Controls;
using Avalonia.Media.Imaging;
public class Race
{
    private Race(string raceName)
    {
        RaceName = raceName;
    }
    public string RaceName { get; }
    public static (Race, Bitmap) RacePick()
    {
        var random = new Random(Guid.NewGuid().GetHashCode());
        int generateRace = random.Next(1, 100);
        Race race;

        if (generateRace < 91)
        {
            race = new Race("Human");
            var raceBitmap = new Bitmap("/Users/pkord/Projects/Avalonia-Dev/AppTest/Assets/human.png");
            return (race, raceBitmap);
        }
        else if (generateRace < 95)
        {
            race = new Race("Halfling");
            var raceBitmap = new Bitmap("/Users/pkord/Projects/Avalonia-Dev/AppTest/Assets/halfling.png");
            return (race, raceBitmap);
        }
        else if (generateRace < 99)
        {
            race = new Race("Dwarf");
            var raceBitmap = new Bitmap("/Users/pkord/Projects/Avalonia-Dev/AppTest/Assets/dwarf.png");
            return (race, raceBitmap);
        }
        else if (generateRace == 100)
        {
            race = new Race("HighElf");
            var raceBitmap = new Bitmap("/Users/pkord/Projects/Avalonia-Dev/AppTest/Assets/highelf.png");
            return (race, raceBitmap);
        }
        else 
        {
            race = new Race("WoodElf");
            var raceBitmap = new Bitmap("/Users/pkord/Projects/Avalonia-Dev/AppTest/Assets/woodelf.png");
            return (race, raceBitmap);
        }
    }
}
