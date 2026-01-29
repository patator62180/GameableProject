using UnityEngine;
using UnityEngine.InputSystem;

public class C4PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    Animator animator;
    SpriteRenderer spriteRenderer;
    InputAction moveAction;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        // direction est un vector2 egal a l'input de notre joueur
        // (1, 0) is on va vers la droite
        // (0, -1) si on va vers le bas etc...
        Vector2 direction = moveAction.ReadValue<Vector2>();

        // votre code ici

        bool isMoving = false;
        animator.SetBool("remplacez avec le nom de votre parameter", isMoving);

        //fin de votre code

        spriteRenderer.flipX = direction.x > 0;

        MovePlayer(direction);
    }

    private void MovePlayer(Vector2 direction)
    {
        transform.position += new Vector3(direction.x, direction.y, 0) * speed * Time.deltaTime;
    }
}
