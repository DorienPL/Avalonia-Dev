using System;
using Avalonia.Controls;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace AppTest.Models;





 public class Army
{
   public Army(string armyName, float armyPrice)
   {
      ArmyName = armyName;
      ArmyPrice = armyPrice;
   }

   public string ArmyName { get; set; }
   public float ArmyPrice { get; set; }
}

