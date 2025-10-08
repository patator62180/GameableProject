using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    Rigidbody2D rb;
    Vector2 movement;
    Animator animatorController;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animatorController = GetComponentInChildren<Animator>();
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
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
