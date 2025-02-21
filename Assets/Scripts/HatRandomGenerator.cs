using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static Unity.Burst.Intrinsics.X86.Avx;

public class HatRandomGenerator : MonoBehaviour
{
    //Introduce Chance integer
    float ChanceHat;

    public GameObject beanie;
    public GameObject wrap;
    public GameObject oldhat;
    public GameObject cap;

    public Transform SpawnLocation;

    bool Hatison;
    bool Wrapison;
    bool beanieison;
    bool capison;

    // Start is called before the first frame update
    void Start()
    {
        Hatison = false;
        Wrapison = false;
        beanieison = false;
        capison = false;

        beanie = Resources.Load("beanie") as GameObject;

    }

    // Update is called once per frame
    void Update()
    {
        //Find and collect game hat objects so systems recognizes them
        GameObject hat = GameObject.Find("Detecthat");
        GameObject beanie = GameObject.Find("beanie");
        GameObject cap = GameObject.Find("Cap");
        GameObject wrap = GameObject.Find("Headwrap");

        hat = Resources.Load("Detecthat") as GameObject;
        beanie = Resources.Load("beanie") as GameObject;
        cap = Resources.Load("Cap") as GameObject;
        wrap = Resources.Load("Headwrap") as GameObject;

        if (Hatison == true)
        {
            Instantiate(oldhat, SpawnLocation.position, Quaternion.identity);
        }
      

        if (Wrapison == true)
        {
            Instantiate(wrap, SpawnLocation.position, Quaternion.identity);
        }
      

        if (beanieison == true)
        {
            Instantiate(beanie, SpawnLocation.position, Quaternion.identity);
        }
       

        if (capison == true)
        {
            Instantiate(cap, SpawnLocation.position, Quaternion.identity);
        }
       


    }


    public void Generate()
    {
        int ChanceHat = Random.Range(1, 4);
        Debug.Log(ChanceHat);

        if (ChanceHat == 4)
        {
            Wrapison = true;
            capison = false;
            Hatison = false;
            beanieison = false;
        }

        if (ChanceHat == 3)
        {
            capison = true;
            Wrapison = false;
            Hatison = false;
            beanieison = false;

        }
        if (ChanceHat == 2)
        {
            beanieison = true;
            capison = false;
            Wrapison = false;
            Hatison = false;
        }
        if (ChanceHat == 1)
        {
            Hatison = true;
            capison = false;
            Wrapison = false;
            beanieison = false;
        }
    }


}
