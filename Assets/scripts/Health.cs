using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour, IDamageable
{
    public int _health;
    public int _maxHealth = 100;

    public int HP
    {
        get { return _health;}
        set 
        { 
            _health = value;
            Debug.Log($"{gameObject.name} has hp {HP}");
            if(_health <= 0)
            {
                Debug.Log($"{gameObject.name} died");
                DestroyObj();
            }
        }
    }

    public void Start()
    {
        _health = _maxHealth;
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
