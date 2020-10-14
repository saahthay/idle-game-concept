using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    public Text profitText;
    public Text priceText;

    public int upgradeProfit;
    public int upgradePrice;

    Mechanics mechanics;

    void Start()
    {
        mechanics = GameObject.FindObjectOfType<Mechanics>();

        profitText.text = "+" + upgradeProfit.ToString();
        priceText.text = upgradePrice.ToString();
    }

    public void UpgradeClick()
    {
        if(mechanics.currentCoinSum >= upgradePrice)
        {
            mechanics.currentCoinSum -= upgradePrice;
            mechanics.profit += upgradeProfit;

            Destroy(gameObject);
        }
    }
}
