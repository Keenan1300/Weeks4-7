using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TankMovmementScript : MonoBehaviour
{
    // Start is called before the first frame update

    float Speed = 0f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 scl = transform.localScale;
        Vector3 pos = transform.position;
        Vector3 squareinscreen = Camera.main.WorldToScreenPoint(pos);

        if (squareinscreen.x < 0 || squareinscreen.x > Screen.width) {
            Speed = 0f;
        }

        if (Input.GetKey("a"))
        {
            //flip sides
            if (scl.x != -1)
            {
                scl.x = scl.x * -1;
            }
            Speed += 0.01f;
            pos.x -= Speed;
            Debug.Log("a works");
        }

        if (Input.GetKey("d"))
        {
            //flip sides
            if (scl.x != 1)
            {
                scl.x = scl.x * -1;
            }
            Speed += 0.01f;
            pos.x += Speed;
            Debug.Log("d works");
        }

        transform.position = pos;
        transform.localScale = scl;
        Speed = 0f;
    }

}
