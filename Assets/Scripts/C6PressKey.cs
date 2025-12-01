using UnityEngine;

// This interaction type is divided in 2 parts:
//     1. We tell the player they can press the 'E' key to interact ('E' is pretty standard for interactions)
//     2. When this key is pressed, something happens
// In chapter 6, we simply log a message in the console
// In chapter 7, we implement a user interface (UI) to show the player the key that needs to be pressed
public class C6PressKey : MonoBehaviour
{
    bool isInteractionPossible = false;

    // Called each time a collider enters the 'trigger' BoxCollider
    void OnTriggerEnter2D(Collider2D other)
    {
        // HANDS-ON: do something only if other has the "Player" tag,
        // then log a message in the console such as "Press E to interact",
        // then find a way to remember that the player can interact
        if (other.transform.CompareTag("Player"))
        {
            Debug.Log("Press E to interact");
            isInteractionPossible = true;
        }
    }

    // Called each time a collider exits the 'trigger' BoxCollider
    void OnTriggerExit2D(Collider2D other)
    {
        // HANDS-ON: do something only if other has the "Player" tag,
        // then find a way to remember that the player can no longer interact
        if (other.transform.CompareTag("Player"))
        {
            isInteractionPossible = false;
        }
    }

    // Update is called once per frame
    // Note: we could use OnTriggerStay2D() instead of Update(),
    // but the tests revealed that there is a Unity optimization
    // that put some colliders asleep to improve the performance
    // and this makes the OnTriggerStay2D() work randomly, which is not great
    void Update()
    {
        // HANDS-ON: if the player can interact and the right key is pressed, then call the OnKeyPressed() method
        if (isInteractionPossible)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                OnKeyPressed();
            }
        }
    }

    // protected: this method is accessible in child classes
    // virtual: this method is overridable in child classes
    protected virtual void OnKeyPressed()
    {
        // To implement in child classes
    }
}
