using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public int damage = 1;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Debug.Log("You touched a spike");
            collision.gameObject.GetComponent<Health>().GetDamage(damage);
        }
    }
}
