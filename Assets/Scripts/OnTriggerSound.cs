using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerSound : MonoBehaviour
{
    AudioSource myClip;

    //when scene is run find the sound from the audio source
    void Start()
    {
        myClip = GetComponent<AudioSource>();

    }

    //When capsule collides with object, play clip
    void OnTriggerEnter(Collider other)
    {
        myClip.Play();
    }

}
