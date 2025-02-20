using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class HueChangingSlider : MonoBehaviour
{
    private SpriteRenderer SpriteRenderer;
    Color slidingcolor;
    float Hue;
    Renderer ColorRenderer;
    public Slider Slider;
    float Sat;
    float Val;

    void Start()
    {
        ColorRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
   {
        Hue = Slider.value;
    }

    //Function changes color thats applied to character sprite
   public void changecolor(float SliderValue)
    {
        ColorRenderer = GetComponent<Renderer>();
   
        ColorRenderer.material.color = Color.HSVToRGB(SliderValue, 1, 1);
    }
}
