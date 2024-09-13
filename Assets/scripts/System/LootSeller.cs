using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootSeller : MonoBehaviour, IInteractable
{
    public Transform playerHand;

    private void OnEnable()
    {
        playerHand = GameObject.FindGameObjectWithTag
                                (StaticNames.PlayerHandTag).transform;
    }

    public void Interact()
    {
        if (playerHand.childCount > 0)
        {
            for (int i = 0; i < playerHand.childCount; i++)
            {
                if (playerHand.GetChild(i).gameObject.activeSelf == true)
                {
                    playerHand.GetChild(i).gameObject.GetComponent<DropItem>().SellItem();
                    Debug.Log("You sold item");
                    break;
                }
            }
        }
    }
}
