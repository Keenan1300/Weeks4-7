using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    public Animator anim;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetFloat("Speed", 1);
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetFloat("Speed", 1);
        
        }
    }
}
