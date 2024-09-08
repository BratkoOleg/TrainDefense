using UnityEngine;

public class WeaponAttack : MonoBehaviour
{
    private Weapon weapon;
    private Transform attackPos;
    private float radius;
    private int damage;

    void Start()
    {
        weapon = gameObject.GetComponentInParent<Weapon>();
        attackPos = gameObject.GetComponentInParent<Transform>();
        radius = weapon.Radius;
        damage = weapon.Damage;
    }

    public void Attack()
    {
        SetHeroAttackRange.Action(attackPos.position, radius, 6, damage, true);
    }
}
