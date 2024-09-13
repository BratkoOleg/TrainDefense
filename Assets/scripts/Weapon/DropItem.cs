using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

interface IDropable
{
    public void Update();
    public void Drop();

    public void TurnOffItem();
}

public class DropItem : MonoBehaviour, IDropable
{
    public string nameItem;
    public GameObject prefabDroppedItem;
    [SerializeField] private Inventory inv;
    public int indexInInv;
    [SerializeField] private int ItemCost;
    private Money money;
    public float FuelEfficienty;
    
    public void Start()
    {
        inv = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();

        if (SceneManager.GetActiveScene().name == "Lobby")
        {
            money = GameObject.FindGameObjectWithTag("Wallet").GetComponent<Money>();
        }   
}

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Drop();
            TurnOffItem();
        }
    }

    public void TurnOffItem()
    {
        Destroy(gameObject);
    }

    public void Burn()
    {
        inv.RemoveObject(indexInInv);
        TurnOffItem(); 
    }

    public void Drop()
    {
        GameObject item = Instantiate(prefabDroppedItem, transform.position, Quaternion.identity);
        item.GetComponent<TakeItem>().inventory = inv;
        inv.RemoveObject(indexInInv);
        TurnOffItem();
    }

    public void SellItem()
    {
        money.EncreaseMoney(ItemCost);
        inv.RemoveObject(indexInInv);
        TurnOffItem();
    }
}
