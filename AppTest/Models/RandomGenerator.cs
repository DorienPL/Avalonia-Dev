namespace AppTest.Models;
using System;
using Avalonia.Controls;
using System.Collections.Generic;
using System.Security.Cryptography;


    public class RandomGenerator
    {
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }
    }
