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
        
        GameObject enemySpawnerPrefab = InstantiateObject(StaticNames.EnemySpawner);

        enemySpawnerPrefab.GetComponent<EnemySpawner>().
                                        Init(objectPoolPrefab.GetComponent<ObjectPool>().
                                            SpawnObjects(_enemyPrefab, _amountOfObjects),
                                            enemySpawnSpots.GetComponent<EnemySpawnSpots>().GetSpots()
                                            );

        GameObject lootSpawner = InstantiateObject(StaticNames.LootSpawner);
        GameObject lootSpawnSpots = InstantiateObject(StaticNames.LootSpawnSpots1);

        lootSpawner.GetComponent<LootSpawner>().
                                        Init(lootSpawnSpots.GetComponent<LootSpawnSpots>().
                                        GetSpots());
    }

    private GameObject InstantiateObject(string name)
    {
        return Instantiate(Resources.Load(name, 
                                    typeof(GameObject))) as GameObject;
    }
}
