using UnityEngine;

public class SpeakingBush : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject TextHint;

    private bool isPlayerColliding;
    private C8PlayerMovement playerMovement;

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
            playerMovement = collision.gameObject.GetComponent<C8PlayerMovement>();
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
                playerMovement.DisableMovement();
            }
            else
            {
                TextBox.SetActive(false);
                playerMovement.EnableMovement();
            }
        }
    }
}
