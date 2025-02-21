using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static Unity.Burst.Intrinsics.X86.Avx;

public class HatRandomGenerator : MonoBehaviour
{
    //Introduce Chance integer
    float ChanceHat;


    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Headwrap").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Detecthat").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("beanie").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Cap").transform.localScale = new Vector3(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
    //Find and collect game hat objects so systems recognizes them
        GameObject hat = GameObject.Find("Detecthat");
        GameObject beanie = GameObject.Find("beanie");
        GameObject cap = GameObject.Find("Cap");
        GameObject wrap = GameObject.Find("Headwrap");

    }


    public void Generate()
    {
        
        //Roll for a random number from 1 to 4. Each of these numbers represent a hat that will randomly be assigned to the player avatar
        int ChanceHat = Random.Range(1, 4);
        Debug.Log(ChanceHat);


        // Depending on the value of chancehat, the random variable, all but one type of hat will be shrunken incredibly small, with one being regularly sized.
       
        
        //Activate the headwrap hat
        if (ChanceHat == 4)
        {
            GameObject.Find("Headwrap").transform.localScale = new Vector3(1, 1, 1);
            GameObject.Find("Detecthat").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("beanie").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("Cap").transform.localScale = new Vector3(0, 0, 0);
        }

        //Activate the cap
        if (ChanceHat == 3)
        {
            GameObject.Find("Cap").transform.localScale = new Vector3(1, 1, 1);
            GameObject.Find("beanie").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("Detecthat").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("Headwrap").transform.localScale = new Vector3(0, 0, 0);

        }

        //Activate the beanie 
        if (ChanceHat == 2)
        {
            GameObject.Find("beanie").transform.localScale = new Vector3(1, 1, 1);
            GameObject.Find("Cap").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("Detecthat").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("Headwrap").transform.localScale = new Vector3(0, 0, 0);
        }

        //Activate the detective hat
        if (ChanceHat == 1)
        {
            GameObject.Find("Detecthat").transform.localScale = new Vector3(1, 1, 1);
            GameObject.Find("beanie").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("Cap").transform.localScale = new Vector3(0, 0, 0);
            GameObject.Find("Headwrap").transform.localScale = new Vector3(0, 0, 0);
        }
    }


}
