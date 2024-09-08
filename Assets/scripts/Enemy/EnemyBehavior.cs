using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private float _speed = 3f;
    public bool canSeePlayer;

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (canSeePlayer == true)
        {
            transform.position = Vector3.MoveTowards
                            (transform.position, _player.transform.position,
                             _speed * Time.deltaTime);
        }
    }

    void OnDisable()
    {
        canSeePlayer = false;
    }
}
