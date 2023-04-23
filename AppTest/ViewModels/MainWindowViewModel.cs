using System;
using Avalonia.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using AppTest.Models;

namespace AppTest.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public string WelcomeMsg => "Welcome to Warhammer Fantasy Roleplay character creator!";
    public string TestWrite => "Elfs are super";

    public RandomGenerator RandomGenerator => new RandomGenerator();
    public static Race Human => new Race("Human", 91);
    
    public string HumanToString = Human.ToString();
    public Race Halfling => new Race("Halfling", 95);
    public Race Dwarf => new Race("Dwarf", 99);
    public Race HighElf => new Race("HighElf", 100);
    public Race WoodElf => new Race("WoodElf", 101);
}


