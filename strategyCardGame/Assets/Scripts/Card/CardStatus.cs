using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardStatus : MonoBehaviour
{
    public List<CardSO> starterCards = new List<CardSO>();
    [SerializeField] TMP_Text damageText;
    [SerializeField] TMP_Text healthText;

    public CardSO currentCard;
    
    void Start()
    {
        AddStatus();
    }

    private void AddStatus()
    {
        int cardnumber = Random.Range(0, starterCards.Count);

        currentCard = starterCards[cardnumber];

        starterCards.RemoveAt(cardnumber);

        healthText.text = currentCard.Health.ToString();
        damageText.text = currentCard.Dmage.ToString();


        Debug.Log(starterCards.Count);
    }
}
