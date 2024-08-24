using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ememy : MonoBehaviour
{
    [SerializeField] private int _health;
    private int _maxHealth = 100;
    public HealthBar healthBar;

    public int HP
    {
        get { return _health;}
        set 
        { 
            _health = value;
            healthBar.ChangeHealth(_health);
            Debug.Log($"Player {gameObject.name} has hp {HP}");
            if(_health <= 0)
            {
                Debug.Log($"Player {gameObject.name} died");
                DestroyObj();
            }
        }
    }

    private void DestroyObj()
    {
        Destroy(gameObject);
    }
}
