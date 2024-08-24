using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ICollectable
{
    private GameObject _obj;
    private Inventory _inventory;
    private Sprite _iconInventory;
    private string _name;

    public Item(Inventory inventory, Sprite icon, string name)
    {
        _inventory = inventory;
        _iconInventory = icon;
        _name = name;
    }

    public void Collect(GameObject player)
    {
        if(_inventory.CheckSlots())
        {
            Debug.Log("You took an item");
            DestroyItem();
        }
        else
        {
            Debug.Log("You dont have space in inv");
        }
    }

    public void DestroyItem()
    {
        
    }
}
