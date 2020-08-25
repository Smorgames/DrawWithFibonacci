using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetVectorSpeed : MonoBehaviour
{
    public string keyForSpeed;
    public Slider slider;

    private void Start()
    {
        slider.value = Random.Range(-50, 50);
    }

    private void Update()
    {
        PlayerPrefs.SetInt(keyForSpeed, (int)slider.value);
    }
}
