using UnityEngine;

public class Flower : MonoBehaviour
{
    public GameObject HUD, GameWinMenu;
    public AudioSource audioSource;

    // Automatically called when an object enters the 2D trigger collider 
    void OnTriggerEnter2D(Collider2D other)
    {
        // Do something only if other has the "Player" tag
        if (other.transform.CompareTag("Player"))
        {
            HUD.SetActive(false);
            GameWinMenu.SetActive(true);
            audioSource.Play();
        }
    }
}
