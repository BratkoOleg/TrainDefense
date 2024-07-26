using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollectable
{
    public void Collect(GameObject player);
    public void DestroyItem();
}

public class TakeItem : MonoBehaviour, ICollectable
{
    public string itemName;
    public GameObject itemObj;
    public bool isOnTrain;
    public Transform train;

    public void TakeLink(GameObject itemObjLink)
    {
        itemObj = itemObjLink;
    }

    public void Collect(GameObject player)
    {
        if(itemObj != null)
        {
            Debug.Log($"{player.name} took {itemName}");
            itemObj.SetActive(true);
            // GameObject item = Instantiate(itemObj, slot.position, Quaternion.identity);
            // item.transform.position = slot.position;
            // item.transform.rotation = slot.rotation;
            // item.transform.SetParent(slot);
            // // itemObj.SetActive(true);
            DestroyItem();
        }
        else
        {
            Debug.Log("Dont have obj link");
        }
    }

    public void DestroyItem()
    {
        Destroy(gameObject);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
            gameObject.GetComponent<Collider>().isTrigger = true;
        }

        if(collision.gameObject.tag == "Train")
        {
            train = collision.gameObject.GetComponent<Transform>();
            isOnTrain = true;
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Train")
        {
            isOnTrain = false;
        }
    }

    public void FixedUpdate()
    {
        if(isOnTrain)
        {
            gameObject.transform.position += train.position;
        }
    }
}
