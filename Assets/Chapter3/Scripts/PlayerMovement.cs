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
