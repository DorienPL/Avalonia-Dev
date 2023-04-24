using System;
using Avalonia.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using AppTest.Models;

namespace AppTest.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public Race race => Race.RacePick();
    public string WelcomeMsg => "Welcome to Warhammer Fantasy Roleplay character creator!";
    public string TestWrite => "Elfs are super";
    
}


