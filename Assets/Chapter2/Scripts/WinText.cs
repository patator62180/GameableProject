using TMPro;
using UnityEngine;

public class WinText : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        
        int coins = GameManager.instance.GetCoinValue();
        string coinText = (coins == 1) ? "1 coin" : coins + " coins";
        textMeshPro.text = "You Won with " + coinText + "!";
    }
}
