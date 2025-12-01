using UnityEngine;

// The flower is a collectible, it disappears when we collect it
public class C6Flower : MonoBehaviour
{
    // Called each time a collider enters the 'trigger' BoxCollider
    void OnTriggerEnter2D(Collider2D other)
    {
        // Do something only if other has the "Player" tag
        if (other.transform.CompareTag("Player"))
        {
            // HANDS-ON: log a message in the console that tells the player that a flower has been collected,
            // then destroy the flower gameObject
            // Bonus: you can implement a simple inventory system to know how many flowers were picked
            Debug.Log("Flower collected!");
            Destroy(gameObject);
        }
    }
}
