using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoLightsturning : MonoBehaviour
{
    float rotspeed;
    float movement;
    bool Turnback;

    //initlialize starting data
    void Start()
    {
        Turnback = false;

        GameObject.Find("Turnangle1").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Turnangle2").transform.localScale = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        //establish speed of the rotation of the disco lights
        if (Turnback == false) {
            movement += 0.15f;
        }

        //light gradually rotates
        rotspeed = Time.deltaTime + movement;

        //If rotation goes too far in one direction, reverse to the other direction.

        if (rotspeed > 50) {
            Turnback = true;
        }
        if (rotspeed < -20)
        {
            Turnback = false;
        }


        //boolean that flips movement
        if (Turnback == true)
        {
            movement -= 0.15f;
        }




        //apply rotation speed to the rotation of the lights, so that the lights will illustrate this.
        Vector3 rot = transform.eulerAngles;
        rot.z = rotspeed;
        transform.eulerAngles = rot;



    }

   public void discomode()
    {
        GameObject.Find("Turnangle1").transform.localScale = new Vector3(1, 1, 1);
        GameObject.Find("Turnangle2").transform.localScale = new Vector3(1, 1, 1);
    }
    public void discomodeOFF()
    {
        GameObject.Find("Turnangle1").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Turnangle2").transform.localScale = new Vector3(0, 0, 0);
    }


}
