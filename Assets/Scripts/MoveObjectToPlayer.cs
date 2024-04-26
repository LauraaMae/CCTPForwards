using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectToPlayer : MonoBehaviour
{
    public Transform targetCamera; // Reference to the camera
    public float speed = 5f; // Speed of movement

    void Update()
    {
        

        // Calculate the direction towards the camera
        Vector3 directionToCamera = (targetCamera.position).normalized;
       
        // Move the object in the direction towards the camera at the specified speed
        transform.Translate(directionToCamera * speed * Time.deltaTime);
    }
}