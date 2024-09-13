using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Money: MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI walletUI;
    public static int Wallet;

    public void EncreaseMoney(int value)
    {
        Wallet += value;
        ChangeUI();
    }

    public void DecreaseMoney(int value)
    {
        Wallet -= value;
        ChangeUI();
    }

    private void ChangeUI()
    {
        walletUI.text = $"Money: {Wallet}";
    }
}