using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float startTime = 25f;
    public Text timerText;

    public GameObject timer;
    public GameObject timeIsUp;

    void Start()
    {
        timerText.text = startTime.ToString();
    }

    void Update()
    {
        if (startTime > 0)
        {
            startTime -= Time.deltaTime;
            timerText.text = Mathf.Round(startTime).ToString();
        }
        else
        {
            timer.SetActive(false);
            timeIsUp.SetActive(true);
        }
    }
}
