using UnityEngine;

namespace Chapter2
{
    public class PlayerMovement : MonoBehaviour
    {
        public float speed = 1f;
        Animator animator;
        Rigidbody2D rb;
        Vector2 direction;

        void Start()
        {
            animator = GetComponent<Animator>();
            rb = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            direction = new Vector2(
                Input.GetAxisRaw("Horizontal"),
                Input.GetAxisRaw("Vertical")
            );

            // Clamp to 4-direction only (no diagonals)
            if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
                direction.y = 0;
            else
                direction.x = 0;

            // Animation logic
            bool isMoving = direction.magnitude > 0;

            animator.SetBool("isMoving", isMoving);
            animator.SetFloat("moveX", direction.x);
            animator.SetFloat("moveY", direction.y);
        }

        private void FixedUpdate()
        {
            MovePlayer();
        }

        void MovePlayer()
        {
            Vector2 newPosition = rb.position + direction.normalized * speed * Time.fixedDeltaTime;
            rb.MovePosition(newPosition);
        }
    }
}
