using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class SaveItemsPositions : MonoBehaviour
{
    [SerializeField] private ItemStorage itemStorage;
    private string saveFilePath;

    private void OnEnable()
    {
        saveFilePath = Application.persistentDataPath + "/PlayerData.json"; 
        itemStorage.onItemAdded += OnItemAdded;
        // itemStorage.onItemRemoved += OnItemRemoved;
    }

    private void OnDisable()
    {
        itemStorage.onItemAdded += OnItemAdded;
        // itemStorage.onItemRemoved += OnItemRemoved;
    }

    private void OnItemAdded(ItemsListClass itemsListClass)
    {
        string savePlayerData = JsonUtility.ToJson(itemsListClass);
            Debug.Log(savePlayerData);
            File.WriteAllText(saveFilePath, savePlayerData);
        // if (File.Exists(saveFilePath))
        // {   
        //     string savePlayerData = JsonUtility.ToJson(itemIDs);
        //     Debug.Log(savePlayerData);
        //     // File.AppendAllText(saveFilePath, "\n");
        //     // File.AppendAllText(saveFilePath, savePlayerData);
        //     File.WriteAllText(saveFilePath, savePlayerData);
        // }
        // else
        // {
        //     string savePlayerData = JsonUtility.ToJson(itemIDs);
        //     Debug.Log(savePlayerData);
        //     File.WriteAllText(saveFilePath, savePlayerData);
        // }
        Debug.Log("saved");
    }

    // private void OnItemRemoved()
    // {
    //     if (File.Exists(saveFilePath))
    //             File.Delete(saveFilePath); 
    //     Debug.Log("removed");
    // }
}
