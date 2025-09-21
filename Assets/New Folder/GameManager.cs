using UnityEngine;
using System.Collections.Generic;
using NUnit.Framework;
public class GameManager: MonoBehaviour
{
    public Cow cow1;
    public Chicken chicken1;
    public Cat cat1;
    public List<Animal> Animal = new List<Animal>();
    public Animal currentAnimals;
    void Start()
    {
        cow1.Intit("kolone", 20,  0);
        Animal.Add(cow1);
        chicken1.Intit("home", 20, 0);
        Animal.Add(chicken1);
        cat1.Intit("Mumu", 25, 0);
        Animal.Add(cat1);
        Debug.Log($"{Animal.Count} animals in total on the farm");
        foreach(Animal a in Animal)
        {
            a.Getstatus();
            a.Feed(2);
            a.MakeSound();
        }

        cow1.Feed("silage",1);
        chicken1.Feed("seed",1);
        cat1.Feed("Kanva",1);
        cow1.Moo();
        chicken1.Sleep();
        cat1.PlayCatToys();

    }

    
}
