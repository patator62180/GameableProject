using UnityEngine;

public class C8Coin : MonoBehaviour
{
    public AudioClip audioClip;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<AudioSource>().PlayOneShot(audioClip);
            Destroy(gameObject);
        }
    }
}