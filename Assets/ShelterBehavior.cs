using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShelterBehavior : MonoBehaviour
{
    [SerializeField] private bool isEnd;
    [SerializeField] private Animator anim;
    public static Action onFinished;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("check");
        if (other.gameObject.tag == StaticNames.PlayerTag && isEnd == true)
        {
            anim.SetTrigger("Finished");
            StartCoroutine(ShowingFinishScreen());
        }
    }

    private IEnumerator ShowingFinishScreen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //temp solution, want to make a hub instead of just load new scene



        yield return new WaitForSeconds(5f);
        Time.timeScale = 0f;
        GameObject screen = Instantiate(Resources.Load
                                        (StaticNames.FinishScreen, 
                                        typeof(GameObject))) as GameObject;
        Cursor.visible = true;
        onFinished?.Invoke();
    }
}
