using UnityEngine;

namespace Chapter3
{
    public class PlayerMovement : MonoBehaviour
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

            //Chapter 3.5 write your code here
            //1. Change the x and y value to make the character move to the right when you press play
            //2. Make the character go to the left
            //3. make the character go up
            //4. make the character go down
            //5. make the character go diagonally

            direction.x = 0;
            direction.y = 0;

            //end of your code here

            MovePlayer(direction);
        }

        private void MovePlayer(Vector2 direction)
        {
            transform.position += new Vector3(direction.x, direction.y, 0) * speed * Time.deltaTime;
        }
    }
}
