using System;
using UnityEngine;
using TMPro;

public class UIDistanceUpdater : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    
    void OnEnable()
    {
        ShelterBehavior.onFinished += UpdateDistanceText;
    }

    private void UpdateDistanceText()
    {
        text.text = $"Total distance: {Math.Round(TrainDistance.ReachedDistance, 2)}";
    }
}
