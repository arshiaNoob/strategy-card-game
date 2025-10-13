using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class CardStatus : MonoBehaviour
{

    public List<CardSO> starterCards = new List<CardSO>();
    [SerializeField] TMP_Text damageText;
    [SerializeField] TMP_Text healthText;


    
    void Start()
    {
        AddStatus();
    }

    private void AddStatus()
    {

        int cardnumber = Random.Range(0, starterCards.Count);

        CardSO currentCard = starterCards[cardnumber];

        healthText.text = currentCard.Health.ToString();
        damageText.text = currentCard.Dmage.ToString();
    }
}
