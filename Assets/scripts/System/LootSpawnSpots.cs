using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootSpawnSpots : MonoBehaviour
{
    private List<Transform> spots = new List<Transform>();
    
    public List<Transform> GetSpots()
    {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            spots.Add(gameObject.transform.GetChild(i));
        }
        return spots;
    }
}
