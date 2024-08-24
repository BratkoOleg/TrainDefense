using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObj : MonoBehaviour
{
    [SerializeField]
    private Inventory _inventory;
    [SerializeField]
    private GameObject _prefab;
    [SerializeField]
    private Sprite _iconInventory;
    [SerializeField]
    private string _name;

    public ItemObj()
    {
        
    }
}
