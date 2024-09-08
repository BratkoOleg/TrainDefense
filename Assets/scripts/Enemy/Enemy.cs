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
                Reset();
            }
        }
    }
    
    private void Reset()
    {
        gameObject.transform.position = Vector3.zero;
        _health = _maxHealth;
        gameObject.SetActive(false);
    }

    public void GetDamage(int damage)
    {
        HP -= damage;
    }
}
