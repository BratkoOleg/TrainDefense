using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class ItemsListClass
{
    public List<ItemID> ItemsList;
}

public class ItemStorage : MonoBehaviour
{
    [SerializeField] private List<GameObject> ItemsList;
    [SerializeField] private List<ItemID> ItemsIds;
    public ItemsListClass itemsListClass;
    // private int ID;

    public Action<ItemsListClass> onItemAdded;
    public Action onItemRemoved;

    private void Start()
    {
        itemsListClass = new ItemsListClass();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            ItemsList.Add(other.gameObject);
            // ID++;
            ItemsIds.Add(other.gameObject.GetComponent<Item>().
                                CreateID(other.gameObject.transform.localPosition));
            
            itemsListClass.ItemsList = ItemsIds;

            // onItemAdded?.Invoke(other.gameObject.GetComponent<Item>().itemID);
            onItemAdded?.Invoke(itemsListClass);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            Debug.Log("check");
            ItemsList.Remove(other.gameObject);
            ItemsIds.Remove(other.gameObject.GetComponent<Item>().itemID);
            // ID--;
            itemsListClass.ItemsList = ItemsIds;
            onItemAdded?.Invoke(itemsListClass);
            // onItemRemoved?.Invoke();
        }
    }
}
