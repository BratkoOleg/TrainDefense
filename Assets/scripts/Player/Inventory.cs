using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<Transform> Slots;
    [SerializeField] private List<bool> hasItem;
    [SerializeField] private GameObject[] items = new GameObject[5];
    [SerializeField] private Transform hand;
    [SerializeField] private GameObject icon;
    private Transform ItemsSlot;

    private static int _currentObjectInHand = 0;
    public static int CurrentObjectInHand
    {
        get {return _currentObjectInHand;}

        set { _currentObjectInHand = value;
                if(_currentObjectInHand < 0)
                    _currentObjectInHand = 0;
                Debug.Log($"You are using {_currentObjectInHand} slot");
            }
    }

    void Start()
    {
        ItemsSlot = GameObject.FindGameObjectWithTag("ItemSlot").gameObject.transform;

        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            Slots.Add(gameObject.transform.GetChild(i));
        }

        foreach (var item in Slots)
        {
            if(item.childCount > 0)
            {
                hasItem.Add(true);
            }
            else
                hasItem.Add(false);
        }
    }

    public int AddItemInInventory(Sprite icon, GameObject item)
    {
        int indexItem = 0;
        for (int i = 0; i < Slots.Count; i++)
        {
            if(hasItem[i] == false)
            {
                hasItem[i] = true;
                GameObject iconObj = Instantiate(this.icon, Slots[i].position, Quaternion.identity);
                iconObj.gameObject.transform.SetParent(Slots[i]);
                iconObj.gameObject.GetComponent<Image>().sprite = icon;
                items[i] = item;
                indexItem = i;
                break;
            }
        }   
        CurrentObjectInHand = indexItem;
        SetCurrentObject(indexItem);
        return indexItem;
    }

    public void RemoveObject(int index)
    {
        hasItem[index] = false;
        Destroy(Slots[index].gameObject.transform.GetChild(0).gameObject);
        items[index] = null;
        SetCurrentObject(CurrentObjectInHand);
    }

    public void ChandeSlot(int index)
    {
        CurrentObjectInHand = index;
        SetCurrentObject(index);
    }

    public bool CheckSlots()
    {
        bool hasSpace = false;
        
        for (int i = 0; i < hasItem.Count; i++)
        {
            if(hasItem[i] == false)
            {
                hasSpace = true;
                break;
            }
        }
        return hasSpace;
    }

    public void SetCurrentObject(int indexCurHand)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if(items[i] != null)
                items[i].SetActive(false);
        }
        
        if(items[CurrentObjectInHand] != null)
            items[CurrentObjectInHand].SetActive(true); 
    }
}
