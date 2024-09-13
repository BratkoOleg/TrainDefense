using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStorage : MonoBehaviour
{
    [SerializeField] private List<GameObject> ItemsList;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            ItemsList.Add(other.gameObject);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            ItemsList.Remove(other.gameObject);
        }
    }
}
