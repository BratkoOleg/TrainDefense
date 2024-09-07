using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private int _amountOfObjects;

    private void Start()
    {
        GameObject player = InstantiateObject(StaticNames.Player);

        GameObject objectPoolPrefab = InstantiateObject(StaticNames.ObjectPool);
        
        GameObject enemySpawnerPrefab = InstantiateObject(StaticNames.Spawner);

        enemySpawnerPrefab.GetComponent<EnemySpawner>().
                                        Init(objectPoolPrefab.GetComponent<ObjectPool>().
                                        SpawnObjects(_enemyPrefab, _amountOfObjects));
    }

    private GameObject InstantiateObject(string name)
    {
        return Instantiate(Resources.Load(name, 
                                    typeof(GameObject))) as GameObject;
    }
}
