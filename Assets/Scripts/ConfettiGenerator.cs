using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfettiGenerator : MonoBehaviour
{

    public SpriteRenderer sr;
    public GameObject prefab;
    public Transform SpawnLocation;
    public GameObject Player;
    Renderer ConfettiColorRenderer;

    bool discomodeon;
    float DiscoTimer;


    // Start is called before the first frame update
    void Start()
    {
        //disco mode starts off at start
        discomodeon = false; 
    }

    // Update is called once per frame
    void Update()
    {
     //if disco mode if on, confetti will fall from the ceiling 
        if (discomodeon == true)
        {
            DiscoTimer -= Time.deltaTime;

            if(DiscoTimer < 1)
            {
                discomodeon = false;
            }

            Instantiate(prefab, SpawnLocation.position, Quaternion.identity);
            Destroy(prefab, 7);
        }
    }
    //discomode function that allows for the disco operation
    public void discomode()
    {
       DiscoTimer = 5;
       discomodeon = true;
       Instantiate(prefab, SpawnLocation.position, Quaternion.identity);
       Destroy(prefab, Random.Range(2,7));
    }

    //Turn off disco
    public void discomodeOFF()
    {
        discomodeon = false;
    }
}
