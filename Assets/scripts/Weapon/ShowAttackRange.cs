using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAttackRange : MonoBehaviour
{
    public float range;

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
