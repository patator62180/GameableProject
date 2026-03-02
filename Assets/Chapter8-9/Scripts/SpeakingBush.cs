using UnityEngine;
using UnityEngine.UI;

public class SpeakingBush : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject TextHint;

    private bool isPlayerColliding;
    private PlayerMovement playerMovement;

    private void Start()
    {
        TextBox.SetActive(false);
        TextHint.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            TextHint.SetActive(true);
            isPlayerColliding = true;
            playerMovement = collision.gameObject.GetComponent<PlayerMovement>();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            TextHint.SetActive(false);
            isPlayerColliding = false;
            playerMovement = null;
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isPlayerColliding)
        {
            if (!TextBox.activeSelf)
            {
                TextHint.SetActive(false);
                TextBox.SetActive(true);
                playerMovement.enableMovement = false;
            }
            else
            {
                TextBox.SetActive(false);
                playerMovement.enableMovement = true;
            }
        }
    }
}
