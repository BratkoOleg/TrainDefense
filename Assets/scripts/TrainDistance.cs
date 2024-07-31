using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TrainDistance : MonoBehaviour
{
    public Transform trainTransform;
    private float defaultPos;
    private float newPos;
    public static float ReachedDistance;
    public TextMeshProUGUI text;


    void Start()
    {
        defaultPos = trainTransform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        newPos = trainTransform.position.x;
        ReachedDistance = newPos - defaultPos;
        text.text = "Distance: " + Math.Round(ReachedDistance, 2);
    }
}
