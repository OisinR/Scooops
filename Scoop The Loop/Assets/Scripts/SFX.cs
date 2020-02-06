using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    AudioSource speaker;
    public AudioClip death;

    void Start()
    {
        speaker = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Die()
    {
        speaker.PlayOneShot(death);
    }
}
