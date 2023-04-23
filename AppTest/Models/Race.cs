using System.Globalization;
using Avalonia.Data.Converters;

namespace AppTest.Models;
using System;
using Avalonia.Controls;
using System.Collections.Generic;
using System.Security.Cryptography;
public class Race
{
    public Race(string raceName, int raceRoll)
    {
        RaceName = raceName;
        RaceRoll = raceRoll;
    }

    public string RaceName { get; set; }
    public int RaceRoll { get; set; }
}