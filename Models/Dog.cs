using System;
using System.Collections.Generic;

namespace inheritance.Models
{
  public class Dog : Animal
  {
    public Dog(string name, List<string> color, string food) : base(name, color, food)
    {
    }
  }
}