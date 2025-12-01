using UnityEngine;

// The harmful zone hurts the playable character
// In chapter 6, we simply log a message in the console
// In chapter 7, we implement a user interface (UI) to know how many lives remain
public class C6HarmfulZone : MonoBehaviour
{
    // Called each time a collider enters the 'trigger' BoxCollider
    void OnTriggerEnter2D(Collider2D other)
    {
        // HANDS-ON: do something only if other has the "Player" tag,
        // then log a message in the console that tells the character is hurt
        if (other.transform.CompareTag("Player"))
        {
            Debug.Log("Playable character is hurt!");
        }
    }
}
