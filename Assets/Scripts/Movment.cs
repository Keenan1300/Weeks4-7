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

        //set speed
        Speed = 0.1f;


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

      

        //Move to the left
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetFloat("Speed", 1);
            pos.x -= Speed;
            Debug.Log("A works");
            Speed = Speed * Time.deltaTime;

            // player flips sides if they are facing the opposite direction
            if (scl.x != -1)
            {
                scl.x = scl.x * -1;
            }
        }


        //Move to the right
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetFloat("Speed", 1);
            pos.x += Speed;
            Debug.Log("D works");
            Speed = Speed * Time.deltaTime;

            // player flips sides if they are facing the opposite direction  
            if (scl.x != 1)
            {
                scl.x = scl.x * -1;
            }
        }
        //if no movment is detected, stop speed
         Speed = 0f;
       
        //Stop Runcycle if player is not moving
        if (Speed !< 0.1f)
        {
            anim.SetFloat("Speed", 0);
        }

        //Apply the position and scale data to the gameobject itself so that changes can be seen
        transform.position = pos;
        transform.localScale = scl;
        
    }

}
