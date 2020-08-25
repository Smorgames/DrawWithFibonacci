using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedIndicator : MonoBehaviour
{
    public Slider slider;
    public Text text;

    void Update()
    {
        text.text = slider.value.ToString();
    }
}
