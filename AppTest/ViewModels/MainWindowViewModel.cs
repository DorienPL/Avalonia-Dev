using System;
using System.IO;
using Avalonia.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using AppTest.Models;
using Avalonia.Markup.Xaml;
using ReactiveUI;
using Avalonia.Interactivity;
using Avalonia.Media.Imaging;

namespace AppTest.ViewModels;
public class MainWindowViewModel : ReactiveObject
{
   
    private IBitmap _raceImage;
    private Statistics? _stats;
    private static class SaveToFile
    {
        private static StreamWriter? _sw;

        public static void WriteToFile()
        {
            _sw = new StreamWriter("/Users/pkord/Desktop/avaloniatest/character.txt");
            _sw.WriteLine("Name");
            _sw.Close();
        }
    }

    //Generating Race and Stats on button
    public void OnButtonClickRace()
    {
        var (race, raceBitmap) = Race.RacePick();
        PickedRace = race.RaceName;
        RaceImage = raceBitmap;
    }

    public static void OnButtonSaveToFile()
    {
        SaveToFile.WriteToFile();
    }
    public void OnButtonClickStatistics()
    {
        _stats = new Statistics(PickedRace);
        StatsWs = _stats.WeaponSkill;
        StatsBs = _stats.BallisticSkill;
        StatsS = _stats.Strength;
        StatsT = _stats.Toughness;
        StatsI = _stats.Initiative;
        StatsDex = _stats.Dexterity;
        StatsAg = _stats.Agility;
        StatsInt = _stats.Intelligence;
        StatsWp = _stats.Willpower;
        StatsFel = _stats.Fellowship;
        HealthPoints = _stats.HealthPoints;
    }
    private string _pickedRace = String.Empty;
    private string _name;
    
    public string Name
    {
        get => _name;
        set => this.RaiseAndSetIfChanged(ref _name, value);
    }
    public string PickedRace
    {
        get => _pickedRace;
        set => this.RaiseAndSetIfChanged(ref _pickedRace, value);
    }
    public IBitmap RaceImage
    {
        get => _raceImage;
        set => this.RaiseAndSetIfChanged(ref _raceImage, value);
    }
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
    private int _healthPoints;
    public int HealthPoints
    {
        get => _healthPoints;
        set => this.RaiseAndSetIfChanged(ref _healthPoints, value);
    }
    // End of stats generating
}