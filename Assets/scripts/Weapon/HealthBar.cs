using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private int maxHealth;
    [SerializeField] private int curHealth;

    public void SetHealth(int maxHP )
    {
        maxHealth = maxHP;
        curHealth = maxHealth;
    }

    public void ChangeHealth(int value)
    {
        curHealth = value;
        float curHealthInPercent = (float)curHealth / maxHealth;
        image.fillAmount = curHealthInPercent;
    }
}
