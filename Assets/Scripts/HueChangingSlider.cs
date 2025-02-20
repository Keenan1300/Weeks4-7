using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class HueChangingSlider : MonoBehaviour
{
    private SpriteRenderer SpriteRenderer;
    Color slidingcolor;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
   {
    }

    //Function changes color thats applied to character sprite
   public void changecolor(float sliderValue)
    {
        
        SpriteRenderer = GetComponent<SpriteRenderer>();
        slidingcolor = new Color(sliderValue, 40, 40);
        SpriteRenderer.color = slidingcolor;
    }
}
