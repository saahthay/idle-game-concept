using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mechanics : MonoBehaviour
{
    public Transform instantiatedPosition;

    public GameObject dragonPrefabs;

    public GameObject coinPrefab;
    public Text coinSum;
    public int currentCoinSum;

    public Text profitText;
    public int profit = 10;

    public int levelUpHealth = 90;

    [Header("DragonState")]
    public List<Sprite> dragonSprite = new List<Sprite>();
    public int StateDragon;

    public GameObject goToShopButton;

    private void Start()
    {
        DragonSpawner();
    }

    private void Update()
    {
        coinSum.text = currentCoinSum.ToString();
        profitText.text = profit.ToString();
    }

    public void GettingCoin(int coin)
    {
        currentCoinSum += coin;

        GameObject instantiatedCoin = Instantiate(coinPrefab) as GameObject;
        Destroy(instantiatedCoin, 1f);
    }

    public void DragonSpawner()
    {
        GameObject dragonInstantiated = Instantiate(dragonPrefabs, instantiatedPosition.transform.position, Quaternion.identity) as GameObject;

        if(StateDragon>0)
        {
            dragonInstantiated.GetComponent<GrowthIncreasing>().isDragon = true;
        }
        
        else
        {
            dragonInstantiated.GetComponent<GrowthIncreasing>().isEgg = true;
        }
        
        dragonInstantiated.GetComponent<SpriteRenderer>().sprite = dragonSprite[StateDragon];
        StateDragon++;
    }
}
