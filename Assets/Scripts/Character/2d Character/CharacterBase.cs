using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Defines a basic character
/// </summary>
public abstract class CharacterBase : MonoBehaviour, iDamageable
{

    public int hp;

    public void onDamaged(int damage)
    {
        hp = hp - damage;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
