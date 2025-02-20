using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    public Animator anim;
    SpriteRenderer spriteRenderer;
    bool Isplaying;

    // Start is called before the first frame update
    void Start()
    {
       Isplaying = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Isplaying = true;
            anim.SetFloat("Speed", 1);
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            Isplaying = true;
            anim.SetFloat("Speed", 1);
        
        }
        if (Isplaying == false) 
        {
            anim.SetFloat("Speed", 0);
        }
        
        Isplaying = false;
    }
}
