using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotPlayer : MonoBehaviour
{
    public bool hasPlayer;
    public bool isTrainMoving;
    private GameObject player;

    public void CheckPlayerOnTheTrain()
    {
        hasPlayer = !hasPlayer;
    } 

    public void CheckTrain()
    {
        isTrainMoving = !isTrainMoving;
    } 

    public void FixedUpdate()
    {
        if(hasPlayer == true && isTrainMoving == true)
        {
            player.transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("On the train");
            CheckPlayerOnTheTrain();
            player = collision.gameObject;
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Out of the train");
            CheckPlayerOnTheTrain();
        }
    }
}
