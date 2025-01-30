using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enabledisable : MonoBehaviour
{
    public SpriteRenderer sr;
    public Enabledisable script;
    public GameObject go;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //sr.enabled = false;
            //script.enabled = false;
            go.SetActive(false);
            //go.activeInHierarchy
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //sr.enabled = true
            // script.enabled = true;
            go.SetActive(true);
        }
    }
}
