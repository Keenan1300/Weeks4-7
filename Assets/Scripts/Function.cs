using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Function : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void Rotate(float x)
    {
      Vector3 standardrotate = transform.eulerAngles;
        standardrotate.z = x*360;
        transform.eulerAngles = standardrotate;
    }

}
