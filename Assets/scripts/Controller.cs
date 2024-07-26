using UnityEngine;

public class Controller : MonoBehaviour
{
    public Transform originalParent;
    public Rigidbody rb;
    public bool isOnObjectB = false;

    void Start()
    {
        // Сохраняем исходного родителя и компонент Rigidbody
        originalParent = transform.parent;
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ObjectB")
        {
            // Устанавливаем Объект Б как родителя Объекта А
            transform.parent = collision.transform;
            isOnObjectB = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "ObjectB")
        {
            // Восстанавливаем исходного родителя
            transform.parent = originalParent;
            isOnObjectB = false;
        }
    }

    void Update()
    {
        if (isOnObjectB)
        {
            // Позволяем Объекту А двигаться, даже когда он на Объекте Б
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            rb.MovePosition(transform.position + movement * Time.deltaTime);
        }
    }
}
