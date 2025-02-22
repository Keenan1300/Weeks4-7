using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Confettifall : MonoBehaviour
{
    float fallspeed;

    // Start is called before the first frame update
    void Start()
    {
        //Establish falling speed of confetti, with each instance falling at random rates, at random x coordinates on the screen.
        fallspeed = Random.Range(0.01f, 0.07f);
        transform.position = new Vector3(Random.Range(-Screen.width, Screen.width), 3, 1);

    }

    // Update is called once per frame
    void Update()
    {
        //Make confetti gradually fall to the floor
        Vector3 pos = transform.position;
        pos.y -= fallspeed;
        transform.position = pos;
    }
}
