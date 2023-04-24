namespace AppTest.Models;
using System;
using Avalonia.Controls;
using System.Collections.Generic;
using System.Security.Cryptography;


    public static class RandomGenerator
    {
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }
        
    }
