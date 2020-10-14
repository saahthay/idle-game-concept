using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAnimation : MonoBehaviour
{
    private Vector2 randomVector;
    private bool move = false;
    
    private void Start()
    {
        StartMotion();
    }
    private void Update()
    {
        if (move)
        {
            transform.Translate(randomVector * Time.deltaTime);
        }
    }
    public void StartMotion()
    {
        //transform.localPosition = Vector2.zero;
        randomVector = new Vector2(Random.RandomRange(-8, 8), Random.RandomRange(-8, 8));
        move = true;
        Destroy(gameObject, 5f);
    }
}
