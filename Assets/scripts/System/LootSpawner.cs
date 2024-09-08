using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class LootSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _lootArray;
    [SerializeField] private int _minAmount;
    [SerializeField] private int _maxAmount;
    private List<Transform> _spawnSpots = new List<Transform>();
    
    public void Init(List<Transform> spots)
    {
        for (int i = 0; i < spots.Count; i++)
        {
            _spawnSpots.Add(spots[i]);
        }

        Spawn();
    }

    private void Spawn()
    {
        for (int i = 0; i < GetRandomAmountOfLoot(); i++)
        {
            GameObject loot = Instantiate(GetRandomLoot(), GetRandomSpot(), Quaternion.identity);
            loot.transform.SetParent(gameObject.transform);
        }
    }

    private int GetRandomAmountOfLoot()
    {
        int number = Random.Range(_minAmount, _maxAmount);
        return number;
    }

    private Vector3 GetRandomSpot()
    {
        Vector3 position = _spawnSpots[Random.Range(0, _spawnSpots.Count - 1)].position;
        return position;
    }

    private GameObject GetRandomLoot()
    {
        GameObject loot = _lootArray[Random.Range(0, _lootArray.Length - 1)];
        return loot;
    }
}
