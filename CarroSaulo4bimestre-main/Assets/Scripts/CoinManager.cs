using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;

    public int coins = 0;
    public TMP_Text coinText;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        coinText.text = "Moedas: " + coins;
    }

    public void AddCoin()
    {
        coins++;
        coinText.text = "Moedas: " + coins;
    }
}
