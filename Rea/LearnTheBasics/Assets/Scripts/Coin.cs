using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int counter = 0; 
    private void OnTriggerEnter2D(Collider2D other)
    {
        counter += 1; 
        CoinText.coinText.text = "Coins: " + counter;
        Debug.Log("Collided");
        Debug.Log(counter);
        Destroy(this.gameObject);
    }
}
