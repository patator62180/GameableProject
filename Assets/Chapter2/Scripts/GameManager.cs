using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TextMeshProUGUI coinText;
    public int coinValue = 0;
    
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
        coinText.text = "Coins: " + coinValue;
    }

    public void SetCoins(int coinValue)
    {
        this.coinValue = coinValue;
        coinText.text = "Coins: " + coinValue;
    }

    public int GetCoinValue()
    {
        return coinValue;
    }
}
