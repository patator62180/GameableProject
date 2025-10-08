using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HarmfulZone : MonoBehaviour
{
    public int damage; // to be set in Inspector
    public AudioSource audioSource;

    // Automatically called when an object enters the 2D trigger collider 
    void OnTriggerEnter2D(Collider2D other)
    {
        // Do something only if other has the "Player" tag
        if (other.transform.CompareTag("Player"))
        {
            // Retrieve the PlayerStats component onto the player
            PlayerStats stats = other.GetComponent<PlayerStats>();
            stats.LoseLifePoints(damage);
            audioSource.Play();
        }
    }
}
