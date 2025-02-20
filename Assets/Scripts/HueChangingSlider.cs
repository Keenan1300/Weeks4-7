using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class HueChangingSlider : MonoBehaviour
{
    Renderer ColorRenderer;
 
    void Start()
    {
        ColorRenderer = GetComponent<Renderer>();
        ColorRenderer.material.color = Color.HSVToRGB(0, 1, 1);
    }

    // Update is called once per frame
    void Update()
   {
    }

    //Function changes color thats applied to character sprite
   public void changecolor(float SliderValue)
    {
        ColorRenderer = GetComponent<Renderer>();
   
        ColorRenderer.material.color = Color.HSVToRGB(SliderValue, 1, 1);
    }
}
