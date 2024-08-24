using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private int enemyAmount;
    [SerializeField] private GameObject[] enemysPrefabs;
    [SerializeField] private int MaxEnemys = 5;

    private void Start()
    {
        CheckEnemys();
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            CheckEnemys();
            if(enemyAmount < MaxEnemys)
            {
                yield return new WaitForSeconds(10);
                GameObject newEnemy = Instantiate(GetRandomEnemy(), gameObject.transform.position, Quaternion.identity);
                newEnemy.transform.SetParent(gameObject.transform);
                CheckEnemys();
            }
        }
    }

    private void CheckEnemys()
    {
        enemyAmount = gameObject.transform.childCount;
    }

    private GameObject GetRandomEnemy()
    {
        GameObject enemy;
        enemy = enemysPrefabs[Random.Range(0, enemysPrefabs.Length - 1)];
        CheckEnemys();
        return enemy;
    }
}
