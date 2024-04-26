using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAllSound : MonoBehaviour
{
    // Function to stop all sounds
    public void StopAllSounds()
    {
        // Get all AudioSources in the scene
        AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();

        // Iterate through each AudioSource and stop it
        foreach (AudioSource audioSource in allAudioSources)
        {
            audioSource.Stop();
        }
    }
}
