using System;
using System.Runtime.InteropServices.ComTypes;
using AppTest.Views;
using Avalonia.Interactivity;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
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
    public int Fate;
    public int Resilience;
    public int Fortune;
    public int Resolve;
    public int Speed;

    public Statistics()
    {
        StatisticsGenerate();
    }
    public Statistics(int weaponSkill, int ballisticSkill, int strength, int toughness, int initiative, 
                        int dexterity, int agility, int intelligence, int willpower, int fellowship)
    {
        WeaponSkill = weaponSkill;
        BallisticSkill = ballisticSkill;
        Strength = strength;
        Toughness = toughness;
        Initiative = initiative;
        Dexterity = dexterity;
        Agility = agility;
        Intelligence = intelligence;
        Willpower = willpower;
        Fellowship = fellowship;
    }
    private void StatisticsGenerate()
    {
        
        string generatedRace = GeneratedRaceText.Text;
        if (generatedRace == "Human")
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
            
        }
        
        else if (generatedRace == "Dwarf")
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            WeaponSkill = random.Next(2, 21);
            BallisticSkill = random.Next(2, 21);
            Strength = random.Next(2, 21);
            Toughness = random.Next(2, 21);
            Initiative = random.Next(2, 21);
            Dexterity = random.Next(2, 21);
            Agility = random.Next(2, 21);
            Intelligence = random.Next(2, 21);
            Willpower = random.Next(2, 21);
            Fellowship = random.Next(2, 21);
            
        }
        else if (generatedRace == "Halfling")
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            WeaponSkill = random.Next(2, 21);
            BallisticSkill = random.Next(2, 21);
            Strength = random.Next(2, 21);
            Toughness = random.Next(2, 21);
            Initiative = random.Next(2, 21);
            Dexterity = random.Next(2, 21);
            Agility = random.Next(2, 21);
            Intelligence = random.Next(2, 21);
            Willpower = random.Next(2, 21);
            Fellowship = random.Next(2, 21);
            
        }
        else if (generatedRace == "HighElf")
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            WeaponSkill = random.Next(2, 21);
            BallisticSkill = random.Next(2, 21);
            Strength = random.Next(2, 21);
            Toughness = random.Next(2, 21);
            Initiative = random.Next(2, 21);
            Dexterity = random.Next(2, 21);
            Agility = random.Next(2, 21);
            Intelligence = random.Next(2, 21);
            Willpower = random.Next(2, 21);
            Fellowship = random.Next(2, 21);
       
        }
        else
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            WeaponSkill = random.Next(22, 41);
            BallisticSkill = random.Next(2, 21);
            Strength = random.Next(2, 21);
            Toughness = random.Next(2, 21);
            Initiative = random.Next(2, 21);
            Dexterity = random.Next(2, 21);
            Agility = random.Next(2, 21);
            Intelligence = random.Next(2, 21);
            Willpower = random.Next(2, 21);
            Fellowship = random.Next(2, 21);
        }
    }
}