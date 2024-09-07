using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlotChanger : MonoBehaviour
{

    private Inventory inventory;
    
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetSlot(0);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetSlot(1);
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetSlot(2);
        }
        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            SetSlot(3);
        }
        if(Input.GetKeyDown(KeyCode.Alpha5))
        {
            SetSlot(4);
        }
    }

    private void SetSlot(int number)
    {
        inventory.ChandeSlot(number);
    }
}
