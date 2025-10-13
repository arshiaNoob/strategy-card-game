using TMPro;
using UnityEngine;

public class ManaManager : MonoBehaviour
{
    // it's 10 just for test*
    public int currentManaAmount = 10;

    [SerializeField] TMP_Text manaText;

    // singleton
    public static ManaManager instance;
    void Awake() { instance = this; }

    // use mana(plase card)
    public void DecreaseManaAmount(int amount)
    {
        currentManaAmount -= amount;
        UpdateUI();
    }

    // next turn(fill mana pool)
    public void SetManaAmount(int amount)
    {
        currentManaAmount = amount;
        UpdateUI();
    }

    public void UpdateUI()
    {
        manaText.text = currentManaAmount.ToString();
    }
}
