using System;
using System.Runtime.InteropServices.ComTypes;
using AppTest.Views;
using Avalonia.Interactivity;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
namespace AppTest.Models;

public class Statistics : MainWindow
{
    private int _weaponSkill;
    private int _ballisticSkill;
    private int _strength;
    private int _toughness;
    private int _initiative;
    private int _dexterity;
    private int _agility;
    private int _intelligence;
    private int _willpower;
    private int _fellowship;
    public int HealthPoints;
    public int Fate;
    public int Resilience;
    public int Fortune;
    public int Resolve;
    public int Speed;
    public Statistics(int weaponSkill, int ballisticSkill, int strength, int toughness, int initiative, 
                        int dexterity, int agility, int intelligence, int willpower, int fellowship)
    {
        _weaponSkill = weaponSkill;
        _ballisticSkill = ballisticSkill;
        _strength = strength;
        _toughness = toughness;
        _initiative = initiative;
        _dexterity = dexterity;
        _agility = agility;
        _intelligence = intelligence;
        _willpower = willpower;
        _fellowship = fellowship;
    }
    public Statistics StatisticsGenerate()
    {
        string generatedRace = GeneratedRaceText.Text;
        Statistics raceStats; 
        if (generatedRace == "Human")
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            raceStats = new Statistics(_weaponSkill, _ballisticSkill, _strength, _toughness, _initiative, _dexterity, _agility, 
                _intelligence, _willpower, _fellowship);
            _weaponSkill = random.Next(2, 21) + 20;
            _ballisticSkill = random.Next(2, 21) + 20;
            _strength = random.Next(2, 21) + 20;
            _toughness = random.Next(2, 21) + 20;
            _initiative = random.Next(2, 21 + 20);
            _dexterity = random.Next(2, 21) + 20;
            _agility = random.Next(2, 21) + 20;
            _intelligence = random.Next(2, 21) + 20;
            _willpower = random.Next(2, 21) + 20;
            _fellowship = random.Next(2, 21) + 20;
            return raceStats;
        }
        else if (generatedRace == "Dwarf")
        {
            raceStats = new Statistics(_weaponSkill, _ballisticSkill, _strength, _toughness, _initiative, _dexterity, _agility,
                _intelligence, _willpower, _fellowship);
            var random = new Random(Guid.NewGuid().GetHashCode());
            _weaponSkill = random.Next(2, 21);
            _ballisticSkill = random.Next(2, 21);
            _strength = random.Next(2, 21);
            _toughness = random.Next(2, 21);
            _initiative = random.Next(2, 21);
            _dexterity = random.Next(2, 21);
            _agility = random.Next(2, 21);
            _intelligence = random.Next(2, 21);
            _willpower = random.Next(2, 21);
            _fellowship = random.Next(2, 21);
            return raceStats;
        }
        else if (generatedRace == "Halfling")
        {
            raceStats = new Statistics(_weaponSkill, _ballisticSkill, _strength, _toughness, _initiative, _dexterity, _agility,
                _intelligence, _willpower, _fellowship);
            var random = new Random(Guid.NewGuid().GetHashCode());
            _weaponSkill = random.Next(2, 21);
            _ballisticSkill = random.Next(2, 21);
            _strength = random.Next(2, 21);
            _toughness = random.Next(2, 21);
            _initiative = random.Next(2, 21);
            _dexterity = random.Next(2, 21);
            _agility = random.Next(2, 21);
            _intelligence = random.Next(2, 21);
            _willpower = random.Next(2, 21);
            _fellowship = random.Next(2, 21);
            return raceStats;
        }
        else if (generatedRace == "HighElf")
        {
            raceStats = new Statistics(_weaponSkill, _ballisticSkill, _strength, _toughness, _initiative, _dexterity, _agility,
                _intelligence, _willpower, _fellowship);
            var random = new Random(Guid.NewGuid().GetHashCode());
            _weaponSkill = random.Next(2, 21);
            _ballisticSkill = random.Next(2, 21);
            _strength = random.Next(2, 21);
            _toughness = random.Next(2, 21);
            _initiative = random.Next(2, 21);
            _dexterity = random.Next(2, 21);
            _agility = random.Next(2, 21);
            _intelligence = random.Next(2, 21);
            _willpower = random.Next(2, 21);
            _fellowship = random.Next(2, 21);
            return raceStats;
        }
        else
        {
            raceStats = new Statistics(_weaponSkill, _ballisticSkill, _strength, _toughness, _initiative, _dexterity, _agility,
                _intelligence, _willpower, _fellowship);
            var random = new Random(Guid.NewGuid().GetHashCode());
            _weaponSkill = random.Next(2, 21);
            _ballisticSkill = random.Next(2, 21);
            _strength = random.Next(2, 21);
            _toughness = random.Next(2, 21);
            _initiative = random.Next(2, 21);
            _dexterity = random.Next(2, 21);
            _agility = random.Next(2, 21);
            _intelligence = random.Next(2, 21);
            _willpower = random.Next(2, 21);
            _fellowship = random.Next(2, 21);
            return raceStats;
        }
    }
}