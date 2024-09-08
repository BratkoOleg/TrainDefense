using UnityEngine;

public class FuelcanBehavior : MonoBehaviour, IInteractable
{
    public TrainFuel trainFuel;
    public float amountFuel = 1f;

    public void Interact()
    {
        trainFuel.AddFuel(amountFuel);
    }
}
