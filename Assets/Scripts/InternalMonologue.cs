using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InternalMonologue : MonoBehaviour
{
    public AudioClip[] sounds;
    private AudioSource audioSource;
    private int currentIndex = 0;
    public float timeBetweenSounds = 0.5f; // Adjust this value to set the delay between sounds can be changed in inspector

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();

        // Play first sound
        PlayNextSound();
    }

    void PlayNextSound()
    {
        // Check if there are more sounds to play
        if (currentIndex < sounds.Length)
        {
            // Set the AudioClip of the AudioSource to the next sound
            audioSource.clip = sounds[currentIndex];

            // Play the sound
            audioSource.Play();

            // Move to next place in index
            currentIndex++;

            // Start a timer to delay playing the next sound
            StartCoroutine(PlayNextSoundWithDelay(audioSource.clip.length));
        }
    }

    IEnumerator PlayNextSoundWithDelay(float delay)
    {
        // Wait for the specified delay set in the inspector
        yield return new WaitForSeconds(delay + timeBetweenSounds);

        PlayNextSound();
    }
}