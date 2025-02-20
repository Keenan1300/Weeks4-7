using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{

    float Speed;
    Boolean isPlaying;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //set vector3 variables for scale and positioning
        Vector3 scl = transform.localScale;
        Vector3 pos = transform.position;
        Vector3 squareinscreen = Camera.main.WorldToScreenPoint(pos);

        //Ensure player remains on screen at all times.
        if (squareinscreen.x < 0 )
        {
            Vector3 boundary = new Vector3(60, 0, 0);
           pos.x = Camera.main.ScreenToWorldPoint(boundary).x;
           
        }   

        if (squareinscreen.x > Screen.width)
        {
            Vector3 boundary = new Vector3(Screen.width - 60, 0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(boundary).x;
            
            
        }


        //Movement mechanics for moving to the left
        if (Input.GetKey("a"))
        {
            
            // player flips sides if they are facing the opposite direction
            isPlaying = true;
            if (scl.x != -1)
            {
                scl.x = scl.x * -1;
            }
            Speed += 0.02f;
            pos.x -= Speed;
            Debug.Log("a works");

            if (Input.GetKeyDown("a"))
            {
                anim.Play("Run", 0, 1);
            }
        }
        //if no movment is detected, stop speed
        else
        {
            Speed = 0f;
        }

        //Movement mechanics for moving to the right
        if (Input.GetKey("d"))
        {
            // player flips sides if they are facing the opposite direction
            isPlaying = true;
            if (scl.x != 1)
            {
                scl.x = scl.x * -1;
            }
            Speed += 0.02f;
            pos.x += Speed;
            Debug.Log("d works");

            if (Input.GetKeyDown("d"))
            {
                anim.Play("Run", 0, 1);
            }
        }

        //if no movment is detected, stop speed
        else
        {
            Speed = 0f;
        }

        //Apply the position and scale data to the gameobject itself so that changes can be seen
        transform.position = pos;
        transform.localScale = scl;
        
    }

}
