using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipePlanner.Domain
{
    public enum Measurement
    {
        Oz,
        Lb,
        Tbps,
        Tps,
    }
   public class Ingedient
   {
       public int Amt { get; set; }
       public Measurement Measure { get; set; }
       public string Ingredient { get; set; }

       //Constructors
       public Ingedient()
       {
           
       }

       public Ingedient(int amt, Measurement measure, string ingredient)
       {
           Amt = amt;
           Measure = measure;
           Ingredient = ingredient;
       }
   }
}
