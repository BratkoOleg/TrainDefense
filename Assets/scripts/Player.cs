using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamageable
{
    public int _health;
    public int _maxHealth = 100;
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

    public void Start()
    {
        _health = _maxHealth;
        healthBar.SetHealth(_maxHealth);
    }

    public void GetDamage(int damage)
    {
        HP -= damage;
    }

    public void DestroyObj()
    {
        Destroy(gameObject);
    }
}
