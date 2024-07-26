using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public float damage = 0.01f;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("You touched a spike");
            collision.gameObject.GetComponent<Player>().GetDamage(damage);
        }
    }
}
