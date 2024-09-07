using UnityEngine;

public class Weapon : MonoBehaviour
{   
    [SerializeField] private int _baseDamage;
    [SerializeField] private float _radius;

    public int Damage {get { return _baseDamage;} set{}}
    public float Radius {get { return _radius;} set{}}
}
