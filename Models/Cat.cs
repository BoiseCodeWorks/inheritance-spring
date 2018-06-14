using System;
using System.Collections.Generic;

namespace inheritance.Models
{
  public class Cat : Animal
  {


    public void Hairball()
    {
      Console.WriteLine("COUGH HACK GROSS!!");
    }

    public Cat(string name, List<string> color, string food) : base(name, color, food)
    {
    }
  }


}