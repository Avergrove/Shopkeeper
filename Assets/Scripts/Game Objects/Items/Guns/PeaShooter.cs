using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The Pea Shooter is a gun used by people who refuse to eat their peas.
/// </summary>
public class PeaShooter : GunBase
{
    GameObject peaShooterProjectilePrefab;
    Transform wielder;

    // Start is called before the first frame update
    void Start()
    {
        peaShooterProjectilePrefab = Resources.Load<GameObject>("Prefabs/Projectiles/Pea Shooter Projectile");
        name = "Pea Shooter";
        description = "Used by people who refuse to eat their peas, the Pea Shooter was invented to feed their enemies nutritious greens!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Fire()
    {
        GameObject peaShooterProjectile = Instantiate(peaShooterProjectilePrefab, wielder);
    }
}
