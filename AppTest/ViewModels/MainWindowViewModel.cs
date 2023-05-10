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
    public void OnButtonClick()
    {
        race = Race.RacePick();
        PickedRace = race.RaceName;
    }
    private string pickedRace = String.Empty;
    public string PickedRace
    {
        get => pickedRace;
        set => this.RaiseAndSetIfChanged(ref pickedRace, value);
    }
    public string WelcomeMsg => "Welcome to Warhammer Fantasy Roleplay character creator!";
    public string TestWrite => "Elfs are super";
    
    
    
}