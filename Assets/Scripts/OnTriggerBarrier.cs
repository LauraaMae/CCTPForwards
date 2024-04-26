using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerBarrier : MonoBehaviour
{

    // Creates box in inspector for UI element to be placed into
    public GameObject uiElement;


    //When capsule collides with object, check it is the player (selected with tag)
   void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            // Enable the UI element
            uiElement.SetActive(true);
        }
    }

    //When capsule stops colliding with object, check it is the player (selected with tag)
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Disable the UI element when the player exits
            uiElement.SetActive(false);
        }
    }

}