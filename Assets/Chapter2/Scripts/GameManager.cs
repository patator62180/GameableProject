using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TextMeshProUGUI coinText;
    public int coins = 0;
    
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        instance = this;
    }
    
    public void OnValidate()
    {
        coinText.text = "Coins: " + coins;
    }

    public void SetCoins(int coinValue)
    {
        this.coins = coinValue;
        coinText.text = "Coins: " + coinValue;
    }

    public int GetCoinValue()
    {
        return coins;
    }
}
