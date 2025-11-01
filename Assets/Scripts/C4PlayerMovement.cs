using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C4PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    Animator animator;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        var direction = new Vector2();

        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");

        //your code here
        // bool isMoving = false;
        // animator.SetBool("replace with the name of your parameter", isMoving);
        //end of your code here

        //solution
        bool isMoving = direction.magnitude > 0;
        animator.SetBool("moving", isMoving);
        //end of solution

        //bonus
        spriteRenderer.flipX = direction.x > 0;
        //end of bonus

        MovePlayer(direction);
    }
    
    private void MovePlayer(Vector2 direction)
    {
        transform.position += new Vector3(direction.x, direction.y, 0) * speed * Time.deltaTime;
    }
}
