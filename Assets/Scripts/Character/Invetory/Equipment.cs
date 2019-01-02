using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour, iInventory
{
    ItemBase helmet;
    GunBase weapon;

    public const int POSITION_WEAPON = 0; 

    public void Add(ItemBase item)
    {
        // TODO: Equip in appropriate places.
        if (item is GunBase)
        {
            GunBase gun = (GunBase) item;
            weapon = gun;
        }
        // TODO: Draw the weapon on the character, pew pew!
    }

    public ItemBase SelectItem(int position)
    {
        throw new System.NotImplementedException();
    }

    public void Use(int position)
    {
        switch (position)
        {
            case POSITION_WEAPON:
                weapon.Use();
                break;
        }
    }

    public void Discard(int position)
    {
        switch (position)
        {
            case POSITION_WEAPON:
                weapon = null;
                break;
        }
    }

    public GunBase GetWeapon()
    {
        return weapon;
    }
}
