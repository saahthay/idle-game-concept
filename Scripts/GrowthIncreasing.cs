using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthIncreasing : MonoBehaviour
{
   
    public int currentHealth;

    [SerializeField] int dragonCoin;

    public GameObject heart;

    public Animator animator;
    public Mechanics mechanics;
    public HealthBar healthBar;
    public bool isDragon = true;
    public bool isEgg = true;

  
    void Start()
    {
        mechanics = GameObject.FindObjectOfType<Mechanics>();
        healthBar = GameObject.FindObjectOfType<HealthBar>();
    }

   
    public void PlayAnim()
    {
        
        if(isDragon)
        {
            animator.SetTrigger("Grow");
            Instantiate(heart, transform);
        }
        else if(isEgg)
        {
            animator.SetTrigger("Grow");
            
        }

        GrowthIncrease(mechanics.profit);
    }

   

    public void GrowthIncrease(int profit)
    {
        int health = currentHealth + profit;

        if (health > mechanics.levelUpHealth)
        {
            mechanics.levelUpHealth += 90 + health; //увеличиваем сложность
            healthBar.setSliderMax(mechanics.levelUpHealth);

            mechanics.GettingCoin(dragonCoin);
            mechanics.DragonSpawner();
            
            Destroy(gameObject);
        }
        else
        {
            currentHealth = health;

            healthBar.setSliderCurrent(currentHealth);
        }
    }
    
}
