using UnityEngine;
using System.Collections.Generic;
using NUnit.Framework;
public class Animal : MonoBehaviour
{
    private string name;
    public string Name
    {
        get => name;
        set => name = (value == "") ? "Chicken" : value;
    }

    private int hunger;
    public int Hunger
    {
        get => hunger;
        set => hunger = (value < 0) ? 0 : value;
    }

    private int happiness;
    public int Happiness
    {
        get => happiness;
        set => happiness = (value < 0) ? 0 : value;
    }

    
    public virtual void Intit(string newName, int newHunger, int newHappiness)
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappiness;
        
    }
    public void AdjustHunger(int Adjust)
    {
        Hunger += Adjust;

    }
    public void AdjustHappiness(int Adjust)
    {
        Happiness += Adjust;

    }
    public void Feed(int newNumber)
    {
        for (int i = 0; i < newNumber; i++)
        {
            AdjustHunger(-10);
            AdjustHappiness(+5);
        }
        Debug.Log($"Feed a total of {newNumber}.Hunger:{Hunger}, Happiness:{Happiness}");
    }
    public void Feed(string newFeed,int newNumber)
    {
        for (int i = 0; i < newNumber; i++)
        {
            AdjustHunger(-10);
            AdjustHappiness(+5);
        }
        Debug.Log($"Feed {newFeed} a total of {newNumber}.Hunger:{Hunger}, Happiness:{Happiness}");
    }
    public void Getstatus()
    {
        Debug.Log($"Animal Name : {Name} Hunger : {Hunger} Happiness : {Happiness} ");
    }
    public virtual void MakeSound()
    {
        Debug.Log($"Growl");
    }


    
}
