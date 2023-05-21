using System;
using System.Runtime.InteropServices.ComTypes;
using AppTest.Views;
using Avalonia.Interactivity;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Markup.Xaml;
using ReactiveUI;
namespace AppTest.Models;
public class Statistics : MainWindow
{
    public int WeaponSkill;
    public int BallisticSkill;
    public int Strength;
    public int Toughness;
    public int Initiative;
    public int Dexterity;
    public int Agility;
    public int Intelligence;
    public int Willpower;
    public int Fellowship;
    public int HealthPoints;
    public Statistics(string race)
    {
        StatisticsGenerate(race);
    }

    private void StatisticsGenerate(string race)
    {
        
        // string race = GeneratedRaceText.Text;
        
        if (race == "Human")
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            WeaponSkill = random.Next(22, 41);
            BallisticSkill = random.Next(22, 41);
            Strength = random.Next(22, 41);
            Toughness = random.Next(22, 41);
            Initiative = random.Next(22, 41);
            Dexterity = random.Next(22, 41);
            Agility = random.Next(22, 41);
            Intelligence = random.Next(22, 41);
            Willpower = random.Next(22, 41);
            Fellowship = random.Next(22, 41);
            int toughnessBonus = Math.Abs(Toughness);
            int willpowerBonus = Math.Abs(Willpower);
            int strengthBonus = Math.Abs(Strength);
            while (strengthBonus >= 10)
            {
                strengthBonus /= 10;
            }
            while (willpowerBonus >= 10)
            {
                willpowerBonus /= 10;
            }

            while (toughnessBonus >= 10)
            {
                toughnessBonus /= 10;
            }
            HealthPoints = strengthBonus + 2 * toughnessBonus + willpowerBonus;
        }
        
        else if (race == "Dwarf")
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            WeaponSkill = random.Next(32, 51);
            BallisticSkill = random.Next(22, 41);
            Strength = random.Next(22, 41);
            Toughness = random.Next(32, 51);
            Initiative = random.Next(22, 41);
            Dexterity = random.Next(32, 51);
            Agility = random.Next(12, 31);
            Intelligence = random.Next(22, 41);
            Willpower = random.Next(42, 61);
            Fellowship = random.Next(12, 31);
            int toughnessBonus = Math.Abs(Toughness);
            int willpowerBonus = Math.Abs(Willpower);
            int strengthBonus = Math.Abs(Strength);
            while (strengthBonus >= 10)
            {
                strengthBonus /= 10;
            }
            while (willpowerBonus >= 10)
            {
                willpowerBonus /= 10;
            }

            while (toughnessBonus >= 10)
            {
                toughnessBonus /= 10;
            }
            HealthPoints = strengthBonus + 2 * toughnessBonus + willpowerBonus;
            
        }
        else if (race == "Halfling")
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            WeaponSkill = random.Next(12, 31);
            BallisticSkill = random.Next(32, 51);
            Strength = random.Next(12, 31);
            Toughness = random.Next(22, 41);
            Initiative = random.Next(22, 41);
            Dexterity = random.Next(32, 51);
            Agility = random.Next(22, 41);
            Intelligence = random.Next(22, 41);
            Willpower = random.Next(32, 51);
            Fellowship = random.Next(32, 51);
            int toughnessBonus = Math.Abs(Toughness);
            int willpowerBonus = Math.Abs(Willpower);
            int strengthBonus = Math.Abs(Strength);
            while (strengthBonus >= 10)
            {
                strengthBonus /= 10;
            }
            while (willpowerBonus >= 10)
            {
                willpowerBonus /= 10;
            }

            while (toughnessBonus >= 10)
            {
                toughnessBonus /= 10;
            }
            HealthPoints = strengthBonus + 2 * toughnessBonus + willpowerBonus;
            
        }
        else if (race == "HighElf")
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            WeaponSkill = random.Next(32, 51);
            BallisticSkill = random.Next(32, 51);
            Strength = random.Next(22, 41);
            Toughness = random.Next(22, 41);
            Initiative = random.Next(42, 61);
            Dexterity = random.Next(32, 51);
            Agility = random.Next(32, 51);
            Intelligence = random.Next(32, 51);
            Willpower = random.Next(32, 51);
            Fellowship = random.Next(22, 41);
            int toughnessBonus = Math.Abs(Toughness);
            int willpowerBonus = Math.Abs(Willpower);
            int strengthBonus = Math.Abs(Strength);
            while (strengthBonus >= 10)
            {
                strengthBonus /= 10;
            }
            while (willpowerBonus >= 10)
            {
                willpowerBonus /= 10;
            }

            while (toughnessBonus >= 10)
            {
                toughnessBonus /= 10;
            }
            HealthPoints = strengthBonus + 2 * toughnessBonus + willpowerBonus;
       
        }
        else
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            WeaponSkill = random.Next(32, 51);
            BallisticSkill = random.Next(32, 51);
            Strength = random.Next(22, 41);
            Toughness = random.Next(22, 41);
            Initiative = random.Next(42, 61);
            Dexterity = random.Next(32, 51);
            Agility = random.Next(32, 51);
            Intelligence = random.Next(32, 51);
            Willpower = random.Next(32, 51);
            Fellowship = random.Next(22, 41);
            int toughnessBonus = Math.Abs(Toughness);
            int willpowerBonus = Math.Abs(Willpower);
            int strengthBonus = Math.Abs(Strength);
            while (strengthBonus >= 10)
            {
                strengthBonus /= 10;
            }
            while (willpowerBonus >= 10)
            {
                willpowerBonus /= 10;
            }

            while (toughnessBonus >= 10)
            {
                toughnessBonus /= 10;
            }
            HealthPoints = strengthBonus + 2 * toughnessBonus + willpowerBonus;
        }
    }
}