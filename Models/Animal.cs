using System;
using System.Collections.Generic;

namespace inheritance.Models
{
  public abstract class Animal: Pet
  {
    public int Legs { get; set; }
    public string Food { get; set; }


    public void Eat(string food)
    {
      if (food == Food)
      {
        Console.WriteLine("MMMMMMMMMmmmm");
      }
      else
      {
        Console.WriteLine("BARF");
      }
    }

    public void Sleep()
    {
      Console.WriteLine("ZZZZzzzzzZZZZzzzz");
    }

    public virtual void Reproduce()
    {
      System.Console.WriteLine("Mammals have live birth");
    }

    public Animal(string name, List<string> color, string food) : base(name, color)
    {
      Name = name;
      Legs = 4;
      Color = color;
      Food = food;
    }







  }
}