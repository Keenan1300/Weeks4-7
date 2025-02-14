using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TankRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 rot = transform.position;
        //Find where mouse is on screen, put it into a variable so that it can be used
        Vector2 mouseOnScreen = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Use the mouse position and subtract it by this game objects position transformation
        Vector2 pointtoward = mouseOnScreen - (Vector2)transform.position;

        //transform the green arrow axis of game object to point towards mouse
        transform.up = pointtoward;
    }
            
}

