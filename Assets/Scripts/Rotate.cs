using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    Slider slider;
    float t;

    void Start()
    {
        t = 1;
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            slider.value = t % slider.maxValue;
        }
       
    }

    }

