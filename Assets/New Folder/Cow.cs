using UnityEngine;
using System.Collections.Generic;
using NUnit.Framework;
public class Cow : Animal 
{
    private float milk;
    public float Milk { get => milk; set => milk = (value < 0) ? 0 : value; }
    public override void Intit(string newName, int newHunger, int newHappiness)
    {
        base.Intit(newName,newHunger,newHappiness);
        Milk = 0;
    }
    public override void MakeSound()
    {
        Debug.Log($"Moooo");
    }
    
    public void Moo()
    {
        AdjustHappiness(+10);
        Debug.Log($"{Name} Happiness +10 ");
        Getstatus();
    }

    
}