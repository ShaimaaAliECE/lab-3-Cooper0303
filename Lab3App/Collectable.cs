using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App {
  public abstract class Collectable : Displayable
{
    public CollectionBoard Board {get; set;}
    public string description;
    public Collectable(string description){
      this.description = description;
    }

    public virtual void AddMe(List<Collectable> collected)
    {
        Console.WriteLine($"{Description} Collected, Congrats!!!!");
        collected.Add(this);
    }

    public abstract void Display();

}

} 
    
    