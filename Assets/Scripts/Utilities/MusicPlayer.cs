using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A component that defines that behaviour of a music player object.
/// </summary>
public class MusicPlayer : MonoBehaviour
{
    AudioSource audioSource;
    Transform following;

    /// <summary>
    /// The music player will always following the main camera by default, and
    /// </summary>
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
        if(audioSource == null)
        {
            throw new MissingComponentException("The music player should be attached to a gameObject with an AudioSource component!");
        }

        following = GameObject.Find("Main Camera").transform;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = following.position;
    }
}
