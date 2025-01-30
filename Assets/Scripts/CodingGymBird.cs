using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodingGymBird : MonoBehaviour
{
    public SpriteRenderer sr;
    public Enabledisable script;
    public AudioSource audioSource;


    // Update is called once per frame
    void Update()
    {
        sr.enabled = audioSource.isPlaying;
    }
}
 