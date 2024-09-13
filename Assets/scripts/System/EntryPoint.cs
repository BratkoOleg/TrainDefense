using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    public bool needTrain;
    public bool needEnemy;
    public bool needLoot;
    public bool isHub;

    [Header("Enemy")]
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private int _amountOfObjects;

    [Header("Hub")]
    [SerializeField] private GameObject store;

    private void Start()
    {
        /*
        Player init
        Train init;
        Object pool init
        Enemy spawn spots init
        Enemy spawner init
        Loot spawner init
        Loot spawn spots init
        Store init
        */

        GameObject player = InstantiateObject(StaticNames.Player);

        if (needEnemy)
        {
            GameObject objectPoolPrefab = InstantiateObject(StaticNames.ObjectPool);
    
            GameObject enemySpawnSpots = InstantiateObject(StaticNames.EnemySpawnSpots1);
            
            GameObject enemySpawnerPrefab = InstantiateObject(StaticNames.EnemySpawner);
    
            enemySpawnerPrefab.GetComponent<EnemySpawner>().
                                            Init(objectPoolPrefab.GetComponent<ObjectPool>().
                                                SpawnObjects(_enemyPrefab, _amountOfObjects),
                                                enemySpawnSpots.GetComponent<EnemySpawnSpots>().GetSpots()
                                                );
        }

        if (needTrain)
        {
            GameObject train = InstantiateObject(StaticNames.Train);
        }

        if (needLoot)
        {
            GameObject lootSpawner = InstantiateObject(StaticNames.LootSpawner);
            GameObject lootSpawnSpots = InstantiateObject(StaticNames.LootSpawnSpots1);
    
            lootSpawner.GetComponent<LootSpawner>().
                                            Init(lootSpawnSpots.GetComponent<LootSpawnSpots>().
                                            GetSpots());
        }

        if (isHub)
        {
            store.SetActive(true);
        }
    }

    private GameObject InstantiateObject(string name)
    {
        return Instantiate(Resources.Load(name, 
                                    typeof(GameObject))) as GameObject;
    }
}
