using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;

public class LoadItems : MonoBehaviour
{
    [SerializeField] private List<GameObject> Items;
    public ItemsListClass itemsListClass;
    private List<ItemID> IDs;
    private string saveFilePath;
    private ItemID itemID;

    private void Start()
    {
        saveFilePath = Application.persistentDataPath + "/PlayerData.json"; 

        if (File.Exists(saveFilePath))
        {
            itemsListClass = new ItemsListClass();
            string loadPlayerData = File.ReadAllText(saveFilePath);
            itemsListClass = JsonConvert.DeserializeObject<ItemsListClass>(loadPlayerData);
            // itemsListClass = JsonUtility.FromJson<ItemsListClass>(saveFilePath);

            IDs = itemsListClass.ItemsList;
            // Debug.Log("loaded " + itemID._id);
            Load(IDs);
        }
    }

    public void Load(List<ItemID> IDs)
    {
        for (int i = 0; i < IDs.Count; i++)
        {
           GameObject item = Instantiate(Items[IDs[i]._id]);
           item.transform.SetParent(gameObject.transform);
           item.transform.position = gameObject.transform.position;
           item.transform.localPosition = IDs[i]._position;
        }
    }
}
