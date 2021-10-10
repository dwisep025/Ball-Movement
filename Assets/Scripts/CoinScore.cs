using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{
    public static int scoreCoin;
    Text scoreCoinText;

    // Start is called before the first frame update
    void Start()
    {
        scoreCoin = 0;
        scoreCoinText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreCoinText.text = scoreCoin.ToString();
    }
}
