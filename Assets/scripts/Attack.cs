using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("isAttacking");
            anim.SetTrigger("finished");
        }
    }
}
