using System.Collections.Generic;

namespace inheritance
{
  public abstract class Pet
  {
     public string Name { get; set; }
     public List<string> Color { get; set; }

     public Pet(string name, List<string> color)
     {
         Name = name;
         Color = color;
     }
  }
}