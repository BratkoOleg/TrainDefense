using UnityEngine;

public class Item : MonoBehaviour
{
    public ItemID itemID;
    [SerializeField] private int _ID;
    private Vector3 _position;

    public ItemID CreateID(Vector3 pos)
    {
        return itemID = new ItemID(_ID, pos);
    }


    // private GameObject _obj;
    // private Inventory _inventory;
    // private Sprite _iconInventory;
    // private string _name;

    // public Item(Inventory inventory, Sprite icon, string name)
    // {
    //     _inventory = inventory;
    //     _iconInventory = icon;
    //     _name = name;
    // }

    // public void Collect(GameObject player)
    // {
    //     if(_inventory.CheckSlots())
    //     {
    //         Debug.Log("You took an item");
    //         DestroyItem();
    //     }
    //     else
    //     {
    //         Debug.Log("You dont have space in inv");
    //     }
    // }

    // public void DestroyItem()
    // {
        
    // }
}
