using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemObj : ScriptableObject
{
    [SerializeField] private Inventory _inventory;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Sprite _iconInventory;
    [SerializeField] private string _name;
}
