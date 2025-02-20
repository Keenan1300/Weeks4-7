using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{

    float Speed;
    Boolean isPlaying;
    public Animator anim;
    SpriteRenderer spriteRenderer;

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
        
        if (Input.GetKey(KeyCode.A))
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                anim.SetFloat("Speed", 1);
            }

            // player flips sides if they are facing the opposite direction
            if (scl.x != -1)
            {
                scl.x = scl.x * -1;
            }
            Speed += 0.02f;
            
            if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetFloat("Speed", 1);
        }
            pos.x -= Speed;
            Debug.Log("a works");
        }
        //if no movment is detected, stop speed
        else
        {
            Speed = 0f;
            anim.SetFloat("Speed", 0);
        }

        //Movement mechanics for moving to the right
    

        if (Input.GetKey("d"))
        {

        // player flips sides if they are facing the opposite direction  
            if (scl.x != 1)
            {
                scl.x = scl.x * -1;
            }
            Speed += 0.02f;
            pos.x += Speed;
            Debug.Log("d works");
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
