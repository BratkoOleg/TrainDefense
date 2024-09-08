using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowEnemyArea : MonoBehaviour
{
    private SphereCollider colliderObj => gameObject.GetComponent<SphereCollider>();

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, colliderObj.radius);
    }
}
