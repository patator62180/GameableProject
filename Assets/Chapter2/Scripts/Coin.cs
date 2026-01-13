using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            int coins = GameManager.instance.GetCoinValue(); 
            GameManager.instance.SetCoins(coins + coinValue);
            Debug.Log("Collided with coin");
            Destroy(this.gameObject);
        }
    }
}
