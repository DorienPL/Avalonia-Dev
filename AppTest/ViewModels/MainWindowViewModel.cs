using System;
using Avalonia.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using AppTest.Models;
using ReactiveUI;

namespace AppTest.ViewModels;

public class MainWindowViewModel : ReactiveObject
{
    public Race race;
    public Statistics Stats;
    //Generating Race and Stats on button
    public void OnButtonClick()
    {
        race = Race.RacePick();
        PickedRace = race.RaceName;
        Stats = new Statistics();
        StatsWs = Stats.WeaponSkill;
        StatsBs = Stats.BallisticSkill;
        StatsS = Stats.Strength;
        StatsT = Stats.Toughness;
        StatsI = Stats.Initiative;
        StatsDex = Stats.Dexterity;
        StatsAg = Stats.Agility;
        StatsInt = Stats.Intelligence;
        StatsWp = Stats.Willpower;
        StatsFel = Stats.Fellowship;
    }
    private string _pickedRace = String.Empty;
    public string PickedRace
    {
        get => _pickedRace;
        set => this.RaiseAndSetIfChanged(ref _pickedRace, value);
    }
    // Genereting stats - może da się lepiej?
    // WeaponSkill
    private int _statsWs;
    public int StatsWs
    {
        get => _statsWs;
        set => this.RaiseAndSetIfChanged(ref _statsWs, value);
    }
    // Balistic Skills
    private int _statsBs;
    public int StatsBs
    {
        get => _statsBs;
        set => this.RaiseAndSetIfChanged(ref _statsBs, value);
    }
    // Strength
    private int _statsS;
    public int StatsS
    {
        get => _statsS;
        set => this.RaiseAndSetIfChanged(ref _statsS, value);
    }
    // Toughness
    private int _statsT;
    public int StatsT
    {
        get => _statsT;
        set => this.RaiseAndSetIfChanged(ref _statsT, value);
    }
    // Initiative
    private int _statsI;
    public int StatsI
    {
        get => _statsI;
        set => this.RaiseAndSetIfChanged(ref _statsI, value);
    }
    // Dexterity
    private int _statsDex;
    public int StatsDex
    {
        get => _statsDex;
        set => this.RaiseAndSetIfChanged(ref _statsDex, value);
    }
    // Agility
    private int _statsAg;
    public int StatsAg
    {
        get => _statsAg;
        set => this.RaiseAndSetIfChanged(ref _statsAg, value);
    }
    // Intelligence
    private int _statsInt;
    public int StatsInt
    {
        get => _statsInt;
        set => this.RaiseAndSetIfChanged(ref _statsInt, value);
    }
    // Willpower
    private int _statsWp;
    public int StatsWp
    {
        get => _statsWp;
        set => this.RaiseAndSetIfChanged(ref _statsWp, value);
    }
    // Fellowship
    private int _statsFel;
    public int StatsFel
    {
        get => _statsFel;
        set => this.RaiseAndSetIfChanged(ref _statsFel, value);
    }
    // End of stats generating
    public string WelcomeMsg => "Welcome to Warhammer Fantasy Roleplay character creator!";
    public string TestWrite => "Elfs are super";
}