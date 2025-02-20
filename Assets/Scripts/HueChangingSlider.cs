using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class HueChangingSlider : MonoBehaviour
{
    //Inititialize mandatory components and material renderer
    Renderer ColorRenderer;
 
    void Start()
    {
    //Set Color at start to Red
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
        //HSV input, where the Hue represents the slider value. Allows for smooth transition between colors in the sprite color
        ColorRenderer = GetComponent<Renderer>();
        ColorRenderer.material.color = Color.HSVToRGB(SliderValue, 1, 1);
    }
}
