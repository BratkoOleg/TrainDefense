using System.Collections;
using UnityEngine;

public class Spike : MonoBehaviour
{
    private bool isTouching = false;
    public int damage = 1;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Debug.Log("You touched a spike");
            isTouching = true;
            StartCoroutine(ContinueDealingDamage(collision.gameObject));
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Debug.Log("You stop");
            isTouching = false;
            StopCoroutine(ContinueDealingDamage(collision.gameObject));
        }
    }

    private IEnumerator ContinueDealingDamage(GameObject obj)
    {
        while (isTouching)
        {
            obj.gameObject.GetComponent<Health>().GetDamage(damage);
            yield return new WaitForSeconds(3f);
        }
    }
}
