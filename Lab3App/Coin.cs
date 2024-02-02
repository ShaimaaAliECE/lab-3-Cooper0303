using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure {

    public int Value { get; protected set; }

    public Coin(string description, int score, int value) : base(description, score)
    {
        Description = description;
        Value = value;
    }

    public void UpdateTotalValue()
    {
        Board.TotalValue += Value;
        Console.WriteLine($"Total Value is updated to {Board.TotalValue}");
    }

    public override void AddMe(List<Collectable> collected)
    {
        base.AddMe(collected);
        UpdateTotalValue();
    }

    public override void Display() {
        Console.WriteLine($"Coin {Description} is displayed");
    }
}
}
