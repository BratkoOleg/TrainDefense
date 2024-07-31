using UnityEngine;

public class Crane : MonoBehaviour, IInteractable
{
    public bool isMoving;
    public Transform tran;
    public float speed = 1f;
    public TrainFuel trainFuel;
    public bool hasFuel;
    
    public void Interact()
    {
        isMoving = !isMoving;
    }

    void Update()
    {
        if(isMoving == true && hasFuel == true)
        {
            tran.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            trainFuel.ChangeFuel(speed);
        }

        if(trainFuel.ChechFuel() <= 0)
        {
            hasFuel = false;
        }
        else
        {
            hasFuel = true;
        }
    }
}
