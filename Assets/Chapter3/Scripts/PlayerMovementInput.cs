using UnityEngine;

namespace Chapter3
{
    public class PlayerMovementInput : MonoBehaviour
    {
        public float speed = 1f;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frames
        void Update()
        {
            Vector2 direction = new Vector2();

            if (Input.GetKey(KeyCode.D))
            {
                //3.6.1 write your code here
                //Change the x value so that the character moves to the right when you press D

                direction.x = 0;
                //end of your code
            }

            //3.6.2 write your code here
            //1. Change the keycode so that the InputSystem listens to the A button input
            //2. Add code so that the character goes left when you press A
            if (Input.GetKey(KeyCode.None))
            {

            }
            //end of your code here

            //3.6.3 paste your code here
            //1. Copy paste a previous if statement
            //2. Modify the parameters so that the character moves up with W
            //3. Do it again for S and down

            //end of your code here

            MovePlayer(direction);
        }

        private void MovePlayer(Vector2 direction)
        {
            transform.position += new Vector3(direction.x, direction.y, 0) * speed * Time.deltaTime;
        }
    }
}
