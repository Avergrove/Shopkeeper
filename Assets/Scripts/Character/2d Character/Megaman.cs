using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Megaman : PlatformPlayerBase
{
    public Equipment equipment;

    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
        this.gameObject.AddComponent<PeaShooter>();
        PeaShooter peaShooter = this.gameObject.GetComponent<PeaShooter>();
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }

    public override void OnFirePressed()
    {
        GetComponent<PeaShooter>().Fire();
        
        Debug.Log("Pew pew pew! Imagination is your best weapon!");
        Debug.Log("The boss is defeated! You get 50 credits!");
    }
}
