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
        if (Input.GetKey(KeyCode.A))
        {
            Isplaying = true;
            anim.SetBool("isPlaying", true);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            Isplaying = true;
            anim.SetBool("isPlaying", true);
        
        }
        if (Isplaying == false) 
        {
            anim.SetBool("isPlaying", false);
        }

        //Stop Runcycle if player is not moving
        Isplaying = false;
    }
}
