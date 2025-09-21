using UnityEngine;
using System.Collections.Generic;
using NUnit.Framework;
public class Chicken  : Animal
{
    private int eggs;
    public int Eggs { get => eggs; set => eggs = (value < 0) ? 0 : value; }
    public override void Intit(string newName, int newHunger, int newHappiness )
    {
        base.Intit(newName, newHunger, newHappiness);
        Eggs = 0;
    }
    public override void MakeSound()
    {
        Debug.Log($"ek,ekkkkkkkkkkk");
    }
    public void Sleep()
    {
        AdjustHunger(+5);
        AdjustHappiness(+10);
        Debug.Log($"{Name} Sleep Hunger:{Hunger}, Happiness:{Happiness}");
    }
}
