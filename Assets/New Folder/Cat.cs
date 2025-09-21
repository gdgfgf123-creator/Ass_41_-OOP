using UnityEngine;

public class Cat : Animal
{
    public override void Intit(string newName, int newHunger, int newHappiness)
    {
        base.Intit(newName, newHunger, newHappiness);
        
    }
    public override void MakeSound()
    {
        Debug.Log($"Meow Meow");
    }
    public void PlayCatToys()
    {
        AdjustHunger(+5);
        AdjustHappiness(+10);
        Debug.Log($"{Name} PlayCatToys Hunger:{Hunger}, Happiness:{Happiness}");
    }
}
