using UnityEngine;

public class GotPlayer : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("On the train");
            collision.gameObject.transform.SetParent(gameObject.transform.parent);
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Out of the train");
            collision.gameObject.transform.SetParent(null);
        }
    }
}
