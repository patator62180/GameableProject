using TMPro;
using UnityEngine;

namespace Chapter1
{
    public class CoinText : MonoBehaviour
    {
        static public TextMeshProUGUI coinText;
        // Start is called before the first frame update
        void Start()
        {
            coinText = GetComponent<TextMeshProUGUI>();
            Debug.Log("hello");

        }
    }
}
