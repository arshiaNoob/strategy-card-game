using TMPro;
using UnityEngine;

public class CardStatus : MonoBehaviour
{
    /* 
        moved this code:
            public List<CardSO> CardsInDeckList = new List<CardSO>();
        to this 'CardDeckController' file for more controll,
        and culling AddStatus func in CardDeckController
        to set card status and more controll.
        delete this comment after reading it :)
    */
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
