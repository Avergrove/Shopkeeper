using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A class that represents a player's controller.
/// Different iControllable objects can be attached to it to allow the controller to control their behaviour
/// </summary>

public class Controller : MonoBehaviour
{
    public string toControl;
    public IControllable controllable;

    // Start is called before the first frame update
    void Start()
    {
        // The game starts out attaching the player controllable to the controller.
        IControllable player = GameObject.Find(toControl).GetComponent<MonoBehaviour>() as IControllable;
        this.controllable = player;

        Debug.Log(player);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            controllable.OnUpPressed();
        }

        if (Input.GetAxisRaw("Vertical") < 0)
        {
            controllable.OnDownPressed();
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            controllable.OnLeftPressed();
        }

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            controllable.OnRightPressed();
        }

        if (Input.GetButtonDown("Jump"))
        {
            controllable.OnJumpPressed();
        }

        if (Input.GetButtonDown("Interact"))
        {
            controllable.OnInteractPressed();
        }

        if (Input.GetButtonDown("Fire"))
        {
            controllable.OnFirePressed();
        }
    }
}
