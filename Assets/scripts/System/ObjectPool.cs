using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public List<GameObject> SpawnObjects(GameObject prefab, int amountOfObjects)
    {
        List<GameObject> pooledObjects = new List<GameObject>();

        for (int i = 0; i < amountOfObjects; i++)
        {
            GameObject obj = Instantiate(prefab);
            pooledObjects.Add(obj);
            obj.SetActive(false);
        }
        return pooledObjects;
    }
}
