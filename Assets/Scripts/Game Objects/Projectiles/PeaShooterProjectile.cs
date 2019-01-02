using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A bullet fired by the pea shooter. Slow, low damage, and moves in a straight line.
/// </summary>
public class PeaShooterProjectile : ProjectileBase
{
    Vector2 startVelocity = new Vector2(5, 0);

    void Start()
    {
        this.GetComponent<Rigidbody2D>().velocity = startVelocity;
    }
}
