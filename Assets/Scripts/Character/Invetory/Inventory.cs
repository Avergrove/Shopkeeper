using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A basic inventory that can store items.
/// </summary>
public class BasicInventory : MonoBehaviour, iInventory
{

    List<ItemBase> items;

    public void Discard(int position)
    {
        items.RemoveAt(position);
    }

    public ItemBase SelectItem(int position)
    {
        return items[position];
    }

    public void Add(ItemBase item)
    {
        items.Add(item);
    }

    public void Use(int position)
    {
        ItemBase item = this.SelectItem(position);
        item.Use();
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
