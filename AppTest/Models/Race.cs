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
        var humanBitmap = new Avalonia.Media.Imaging.Bitmap ("/Users/pkord/Projects/Avalonia-Dev/AppTest/Assets/human.png");
        var halflingBitmap = new Avalonia.Media.Imaging.Bitmap("/Users/pkord/Projects/Avalonia-Dev/AppTest/Assets/halfling.png");
        var dwarfBitmap = new Avalonia.Media.Imaging.Bitmap("/Users/pkord/Projects/Avalonia-Dev/AppTest/Assets/dwarf.png");
        var highElfBitmap = new Avalonia.Media.Imaging.Bitmap("/Users/pkord/Projects/Avalonia-Dev/AppTest/Assets/highelf.png");
        var woodElfBitmap = new Avalonia.Media.Imaging.Bitmap("/Users/pkord/Projects/Avalonia-Dev/AppTest/Assets/woodelf.png");
        if (generateRace < 91)
        {
            race = new Race("Human");
            var raceBitmap = humanBitmap;
            return (race, raceBitmap);
        }
        else if (generateRace < 95)
        {
            race = new Race("Halfling");
            var raceBitmap = halflingBitmap;
            return (race, raceBitmap);
        }
        else if (generateRace < 99)
        {
            race = new Race("Dwarf");
            var raceBitmap = dwarfBitmap;
            return (race, raceBitmap);
        }
        else if (generateRace == 100)
        {
            race = new Race("HighElf");
            var raceBitmap = highElfBitmap;
            return (race, raceBitmap);
        }
        else 
        {
            race = new Race("WoodElf");
            var raceBitmap = woodElfBitmap;
            return (race, raceBitmap);
        }
    }
}
