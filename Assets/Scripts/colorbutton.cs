using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorbutton : MonoBehaviour
{
    public SpriteRenderer colorchange;
    bool changeitup = false;

    private void Start()
    {
        colorchange.color = Random.ColorHSV();
    }

    // Update is called once per frame
    void Update()
    {
        if (changeitup == true)
        {
            colorchange.color = Random.ColorHSV();
        }
    }
}
