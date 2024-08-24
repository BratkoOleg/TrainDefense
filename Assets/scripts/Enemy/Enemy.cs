using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
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
            Debug.Log($"Enemy {gameObject.name} has hp {HP}");
            if(_health <= 0)
            {
                Debug.Log($"Enemy {gameObject.name} died");
                DestroyObj();
            }
        }
    }

    private void DestroyObj()
    {
        Destroy(gameObject);
    }

    public void GetDamage(int damage)
    {
        HP -= damage;
    }
}
