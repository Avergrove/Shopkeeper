using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signboard : MonoBehaviour, IInteractable
{

    public string message;

    public void interact()
    {
        Debug.Log(string.Format("Message: {0}", this.message));
    }
}
