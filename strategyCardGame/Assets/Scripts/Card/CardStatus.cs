using TMPro;
using UnityEngine;

public class CardStatus : MonoBehaviour
{
    [SerializeField] TMP_Text damageText;
    [SerializeField] TMP_Text healthText;
    [SerializeField] TMP_Text manaText;
    [SerializeField] public GameObject CardManaBorder;

    public CardSO currentCard;

    public void AddStatus(CardSO card)
    {
        currentCard = card;
        healthText.text = card.Health.ToString();
        damageText.text = card.Dmage.ToString();
        manaText.text = card.Mana.ToString();
    }
}
