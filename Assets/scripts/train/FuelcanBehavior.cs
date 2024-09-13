using UnityEngine;

public class FuelcanBehavior : MonoBehaviour, IInteractable
{
    public TrainFuel trainFuel;
    public float amountFuel = 1f;

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
                if (playerHand.GetChild(i).gameObject.activeSelf == true &&
                    playerHand.GetChild(i).gameObject.tag == "Fuel")
                {
                    playerHand.GetChild(i).gameObject.GetComponent<DropItem>().Burn();
                    trainFuel.AddFuel(playerHand.GetChild(i).gameObject.GetComponent<DropItem>().FuelEfficienty);
                    break;
                }
            }
        }
    }
}
