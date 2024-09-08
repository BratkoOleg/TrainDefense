using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private int _amountOfObjects;

    private void Start()
    {
        GameObject player = InstantiateObject(StaticNames.Player);

        GameObject objectPoolPrefab = InstantiateObject(StaticNames.ObjectPool);

        GameObject enemySpawnSpots = InstantiateObject(StaticNames.EnemySpawnSpots1);
        
        GameObject enemySpawnerPrefab = InstantiateObject(StaticNames.Spawner);

        enemySpawnerPrefab.GetComponent<EnemySpawner>().
                                        Init(objectPoolPrefab.GetComponent<ObjectPool>().
                                            SpawnObjects(_enemyPrefab, _amountOfObjects),
                                            enemySpawnSpots.GetComponent<EnemySpawnSpots>().GetSpots()
                                            );
    }

    private GameObject InstantiateObject(string name)
    {
        return Instantiate(Resources.Load(name, 
                                    typeof(GameObject))) as GameObject;
    }
}
