using UnityEngine;

public class Crane : MonoBehaviour, IInteractable
{
    public GameObject floorTrain;
    public bool isMoving;
    public Transform tran;
    
    public void Interact()
    {
        isMoving = !isMoving;
        floorTrain.GetComponent<GotPlayer>().CheckTrain();
    }

    void FixedUpdate()
    {
        if(isMoving == true)
        {
            tran.position += new Vector3(1, 0, 0) * Time.deltaTime;
        }
    }
}
