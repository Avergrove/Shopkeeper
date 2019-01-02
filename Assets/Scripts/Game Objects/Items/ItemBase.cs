using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemBase : MonoBehaviour, iUsable
{
    public int itemId;
    public Sprite image;
    public string name;
    public string description;

    public virtual void Use()
    {
        throw new System.NotImplementedException();
    }
}
