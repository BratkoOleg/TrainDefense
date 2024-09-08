using UnityEngine;
using UnityEngine.UI;

public class TrainFuel : MonoBehaviour
{
    public Transform trainTransform;
    private float defaultPos;
    private float newPos;
    public Image image;
    public float maxFuel;
    public float curFuel;
    public bool isInfinite;

    void Start()
    {
        curFuel = maxFuel;
    }

    public void ChangeFuel(float value)
    {
        if(isInfinite)
            value = 0;
            
        curFuel -= value / 60;
        Debug.Log($"Using {value} fuel");
        float curFuelInPercent = curFuel / maxFuel;
        image.fillAmount = curFuelInPercent;
    }

    public float ChechFuel()
    {
        return curFuel;
    }

    public void AddFuel(float fuel)
    {
        curFuel += fuel;
        if(curFuel >= maxFuel)
            curFuel = maxFuel;
            
        float curFuelInPercent = curFuel / maxFuel;
        image.fillAmount = curFuelInPercent;
    }
}
