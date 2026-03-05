using UnityEngine;
using UnityEngine.Tilemaps;

public class C8PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 1f;
    public Animator animatorController;
    public Tilemap tilemap;
    public TilemapData tilemapData;
    private bool enableMovement;
    private Vector2 movement;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        enableMovement = true;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        animatorController.SetBool("IsMoving", movement != Vector2.zero);        
    }

    void FixedUpdate()
    {
        if(!enableMovement)
        {
            return;
        }

        var currentTile = (Tile)tilemap.GetTile(tilemap.WorldToCell(transform.position));
        if (tilemapData.GetFloortype(currentTile) != EFloortype.Ice)
        {
            rb.linearVelocity = Vector2.zero;
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
        else
        {
            rb.AddForce(100 * movement * moveSpeed * Time.fixedDeltaTime);
        }
    }
    
    public void EnableMovement() => enableMovement = true;
    public void DisableMovement() => enableMovement = false;
}
