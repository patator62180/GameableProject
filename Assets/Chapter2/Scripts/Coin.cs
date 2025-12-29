using UnityEngine;

namespace Chapter1
{
    public class Coin : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                int coinValue = GameManager.instance.GetCoinValue(); 
                GameManager.instance.SetCoins(coinValue + 1);
                Debug.Log("Collided with coin");
                Debug.Log(coinValue);
                Destroy(this.gameObject);
            }
        }
    }
}
