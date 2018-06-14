using System;
using System.Collections.Generic;

namespace inheritance.Models
{
  public class Bird : Animal
  {
    public override void Reproduce()
    {
      Console.WriteLine("I Laid an egg!");
    }

 
    public Bird(string name, List<string> color, string fd) : base(name, color, fd)
    {
      Legs = 2;
    }
  }
}

