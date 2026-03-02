using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    Rigidbody2D rb;
    Vector2 movement;
    Animator animatorController;
    C8AnimationCallbacks animationCallbacks;
    [System.NonSerialized] public bool enableMovement;
    public Tilemap tilemap;
    public TilemapData tilemapData;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animatorController = GetComponent<Animator>();
        animationCallbacks = GetComponent<C8AnimationCallbacks>();
        enableMovement = true;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        if (animatorController)
        {
            if (movement != Vector2.zero)
            {
                animatorController.SetFloat("x", movement.x);
                animatorController.SetFloat("y", movement.y);
                animatorController.SetBool("IsMoving", true);
            }
            else
            {
                animatorController.SetBool("IsMoving", false);
            }
        }

        var currentTile = (Tile) tilemap.GetTile(tilemap.WorldToCell(transform.position));
        animationCallbacks.floortype = tilemapData.GetFloortype(currentTile);
    }

    void FixedUpdate()
    {
        if(!enableMovement)
        {
            return;
        }

        if (animationCallbacks.floortype != EFloortype.Ice)
        {
            rb.linearVelocity = Vector2.zero;
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
        else
        {
            rb.AddForce(100 * movement * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
