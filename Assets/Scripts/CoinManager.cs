using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public int coinCount;
    public Text collectableText;
    public GameObject elevator;
    public GameObject door;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        collectableText.text = "Coin Count: " + coinCount.ToString();

        if(coinCount == 10)
        {
            Destroy(door);
        }
    }
}
