using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IDamageable
{
    public void GetDamage(float value);
}

public class Player : MonoBehaviour, IDamageable
{
    private float _health;
    private float _maxHealth = 100f;

    public float Health
    {
        get { return _health;}
        set 
        { 
            _health = value;
            Debug.Log($"Current hp {Health}");
            if(_health <= 0)
                Debug.Log("You died");
        }
    }

    public void Start()
    {
        _health = _maxHealth;
    }

    public void GetDamage(float damage)
    {
        Health -= damage;
    }
}
