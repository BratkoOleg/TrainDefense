using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    private int enemyAmount;
    private int MaxEnemys = 5;
    private List<GameObject> _enemys;

    public void Init(List<GameObject> pooledEnemys)
    {
        _enemys = pooledEnemys;

        foreach (var enemy in _enemys)
        {
            enemy.transform.SetParent(gameObject.transform);
        }

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
                GameObject newEnemy = GetRandomEnemy();
                newEnemy.SetActive(true);
                CheckEnemys();
            }
        }
    }

    private void CheckEnemys()
    {
        int activeObjects = 0;
        for (int i = 0; i < _enemys.Count; i++)
        {
            if(_enemys[i].activeSelf == true)
                activeObjects++;
        }
        enemyAmount = activeObjects;
    }

    private GameObject GetRandomEnemy()
    {
        GameObject enemy;
        enemy = _enemys[Random.Range(0, _enemys.Count - 1)];
        CheckEnemys();
        return enemy;
    }
}
