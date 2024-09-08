using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class LoadNextScene : MonoBehaviour
{
    [SerializeField] private Button _loadNextStationButton;

    void OnEnable()
    {
        _loadNextStationButton.onClick.AddListener(LoadScene);
    }

    private void LoadScene()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void OnDisable()
    {
        _loadNextStationButton.onClick.RemoveAllListeners();
    }
}
