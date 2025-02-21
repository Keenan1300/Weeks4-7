using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HatRandomGenerator : MonoBehaviour
{
    //Introduce Chance integer
    int ChanceHat;
    
    //Find and collect game hat objects so systems recognizes them
    GameObject hat = GameObject.Find("90shat");
    GameObject beanie = GameObject.Find("beanie");
    GameObject cap = GameObject.Find("Cap");
    GameObject wrap = GameObject.Find("Headwrap");




    // Start is called before the first frame update
    void Start()
    {
        //Ensure all hats are invisible at the start of the game. None have been selected yet!
        hat.SetActive(false);
        wrap.SetActive(false);
        beanie.SetActive(false);
        cap.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      
    }


    public void Generate()
    {
        ChanceHat = Random.Range(1, 4);

        if (ChanceHat == 4) 
        {
            GameObject hat = GameObject.Find("90shat");
            hat.SetActive(true);
        }

        if (ChanceHat == 3)
        {
            GameObject beanie = GameObject.Find("beanie");
            beanie.SetActive(true);
        }
        if (ChanceHat == 2)
        {
            GameObject cap = GameObject.Find("Cap");
            cap.SetActive(true);
        }
        if (ChanceHat == 1)
        {
            GameObject wrap = GameObject.Find("Headwrap");
            wrap.SetActive(true);
        }

    }


}
