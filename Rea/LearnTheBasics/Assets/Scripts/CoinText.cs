using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class CoinText : MonoBehaviour
{
    static public TextMeshProUGUI coinText; 
    // Start is called before the first frame update
    void Start()
    {
        coinText = GetComponent<TextMeshProUGUI>();
        Debug.Log("hello");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
