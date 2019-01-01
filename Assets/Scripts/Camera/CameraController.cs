using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Defines the behaviour of the camera
 */ 
public class CameraController : MonoBehaviour
{
    Vector3 offset;
    public Transform following;

    // Follows the player when the game starts
    void Start()
    {
        offset = transform.position - following.position;
    }

    // Update is called once per frame
    void Update()
    {
        // this.transform.position = following.position;
        this.transform.position = following.position + offset;
    }
}
