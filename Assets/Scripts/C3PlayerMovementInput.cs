using UnityEngine;

public class C3PlayerMovementInput : MonoBehaviour
{
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = new Vector2();

        if (Input.GetKey(KeyCode.D))
        {
            // 3.6.1
            //your code here
            direction.x = 1;
            //end of your code
        }

        //3.6.2
        //your code here
        if (Input.GetKey(KeyCode.None))
        {

        }
        //end of your code here

        //3.6.3

        //end of your code here

        direction.Normalize();

        MovePlayer(direction);
    }

    private void MovePlayer(Vector2 direction)
    {
        transform.position += new Vector3(direction.x, direction.y, 0) * speed * Time.deltaTime;
    }
}
