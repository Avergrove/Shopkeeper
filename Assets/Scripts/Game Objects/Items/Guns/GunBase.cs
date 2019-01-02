using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBase : ItemBase, iFireable, iEquippable
{

    ProjectileBase projectile;
    int ammoCount;
    int magazineSize;

    public void Equip()
    {
        throw new System.NotImplementedException();
    }

    public virtual void Fire()
    {
        throw new System.NotImplementedException(string.Format("{0}.Fire() is a method stub, it is to be overriden by an extended class. ", this.GetType().ToString()));
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
