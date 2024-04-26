using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public Vector3 direction = Vector3.forward; // Direction of movement
    public float speed = 5f; // Speed of movement

    void Update()
    {
        // Move the object in the specified direction at the specified speed
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
