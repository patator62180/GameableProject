using System.Collections;
using UnityEngine;

public class C8Coin : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<AudioSource>().Play();
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<CapsuleCollider2D>().enabled = false;

            StartCoroutine(DelayedDestroyCoin());
        }
    }

    private IEnumerator DelayedDestroyCoin()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}