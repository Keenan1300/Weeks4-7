using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HueChangingSlider : MonoBehaviour
{
    private SpriteRenderer SpriteRenderer;
    public Color slidingcolor;

    void Start()
    {
     slidingcolor = new Color(0, 100, 100);
    }

    // Update is called once per frame
    void Update()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        SpriteRenderer.color = slidingcolor;
    }

   public void changecolor(float change)
    {
        slidingcolor = new Color(change * 2, 100, 100);
    }
}
