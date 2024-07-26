using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IDropable
{
    public void Update();
    public void Drop();

    public void TurnOffItem();
}

public class DropItem : MonoBehaviour, IDropable
{
    public string nameItem;
    public GameObject prefabDroppedItem;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Drop();
            TurnOffItem();
        }
    }

    public void TurnOffItem()
    {
        gameObject.SetActive(false);
    }

    public void Drop()
    {
        GameObject item = Instantiate(prefabDroppedItem, transform.position, Quaternion.identity);
        item.GetComponent<TakeItem>().TakeLink(gameObject);
    }
}
