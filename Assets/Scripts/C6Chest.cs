using UnityEngine;

// The chest holds a certain amount of coins that can be looted
// The class inherits from C6PressKey, meaning it requires the 'E' key to be pressed to start the interaction
public class C6Chest : C6PressKey
{
    public int nbOfCoins = 3;

    // protected: this method is accessible in child classes
    // override: this method is overriding the base class implementation
    protected override void OnKeyPressed()
    {
        // First, call the base implementation in case there is a common logic to execute
        base.OnKeyPressed();

        // Then, implement the behaviour of this specifc interaction type:
        // HANDS-ON: log a message in the console to show how many coins were collected in this chest,
        // then destroy the flower gameObject
        // Bonus: you can implement a simple inventory system to know how many coins were collected
        Debug.Log(nbOfCoins + " coins collected!");
        Destroy(gameObject);
    }
}
