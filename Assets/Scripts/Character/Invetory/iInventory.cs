using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A interface that defines the basic behaviour of an inventory.
/// </summary>
public interface iInventory
{

    /// <summary>
    /// Stores an item into the inventory
    /// </summary>
    /// <param name="item">The item to store in the inventory</param>
    void Add(ItemBase item);

    /// <summary>
    /// Selects an item in the provided position
    /// </summary>
    /// <param name="position">The position of the item to select</param>
    /// <returns>The item at the provided position</returns>
    ItemBase SelectItem(int position);


    /// <summary>
    /// Uses an item in the inventory
    /// </summary>
    /// <param name="position">The item's position in the inventory.</param>
    void Use(int position);

    /// <summary>
    /// Discards an item from the inventory.
    /// </summary>
    /// <param name="item">The item's position in the inventory.</param>
    void Discard(int position);
}
