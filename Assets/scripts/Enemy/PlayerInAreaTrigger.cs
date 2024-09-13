using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInAreaTrigger : MonoBehaviour
{
    [SerializeField] private EnemyBehavior _enemy;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == StaticNames.PlayerTag)
        {
            _enemy.canSeePlayer = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == StaticNames.PlayerTag)
        {
            _enemy.canSeePlayer = false;
        }
    }
}
