using UnityEngine;
using UnityEngine.Events;

public class C8Trigger : MonoBehaviour
{
    public UnityEvent<Collider2D> TriggerEnter2D, TriggerStay2D, TriggerExit2D;
    
    private SpriteRenderer m_spriteRenderer;

    private void Start()
    {
        m_spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TriggerEnter2D.Invoke(collision);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        TriggerExit2D.Invoke(collision);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        TriggerStay2D.Invoke(collision);
    }

    public void SetColorGreen(Collider2D collision)
    {
        m_spriteRenderer.color = Color.green;
    }

    public void SetColorRed(Collider2D collision)
    {
        m_spriteRenderer.color = Color.red;
    }
}
