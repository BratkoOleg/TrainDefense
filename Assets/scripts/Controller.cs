using UnityEngine;

public class Controller : MonoBehaviour
{
    public Transform originalParent;
    public Rigidbody rb;
    public bool isOnObjectB = false;

    void Start()
    {
        originalParent = transform.parent;
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ObjectB")
        {
            transform.parent = collision.transform;
            isOnObjectB = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "ObjectB")
        {
            transform.parent = originalParent;
            isOnObjectB = false;
        }
    }

    void Update()
    {
        if (isOnObjectB)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            rb.MovePosition(transform.position + movement * Time.deltaTime);
        }
    }
}
