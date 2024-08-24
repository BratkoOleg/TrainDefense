using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private float _speed = 3f;

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, _speed * Time.deltaTime);
    }
}
