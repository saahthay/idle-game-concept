using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;

    public Image fill;

    public void setSliderCurrent(int health)
    {
        slider.value = health;

        fill.color = gradient.Evaluate(2f);
    }

    public void setSliderMax(int health)
    {
        slider.maxValue = health;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
