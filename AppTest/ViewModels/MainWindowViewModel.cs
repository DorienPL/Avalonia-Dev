using System;
using Avalonia.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using AppTest.Models;
using ReactiveUI;
using Avalonia.ReactiveUI;
using Avalonia.Interactivity;

namespace AppTest.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public SimpleViewModel SimpleViewModel { get;}   = new SimpleViewModel();
    public void OnClickRace(object? sender, RoutedEventArgs e)
    {

        // race = Race.RacePick();
        this.SimpleViewModel.Name = "teest2";    
    } 
    
    public string WelcomeMsg => "Welcome to Warhammer Fantasy Roleplay character creator!";
    public string TestWrite => "Elfs are super";
    public string Test => "Testowanie";
}



