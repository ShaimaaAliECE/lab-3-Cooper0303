using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
   public abstract class Treasure : Collectable
{
    public int Score { get; protected set; }

    public Treasure(string decsription, int score) : base(description)
    {
        Score = score;
    }

    public override void AddMe(List<Collectable> collected)
    {
        base.AddMe(collected);
        UpdateTotalScore();

    }
    public virtual void UpdateTotalScore()
    {
        Board.TotalScore += Score;
        Console.WriteLine($"Total Score is updated to {Board.TotalScore}");
    
    }
 }
 }