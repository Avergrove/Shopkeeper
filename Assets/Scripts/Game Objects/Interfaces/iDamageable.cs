using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An interface that deinfes an implementing class as damageable.
/// </summary>
public interface iDamageable
{
    /// <summary>
    /// Event that runs when the implementing object is damaged.
    /// </summary>
    /// <param name="damage">The amount of damage done to the implementing object.</param>
    void onDamaged(int damage);
}
