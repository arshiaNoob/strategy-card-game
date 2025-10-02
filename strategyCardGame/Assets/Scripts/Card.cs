using System;
using TMPro;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] TMP_Text damageText;
    [SerializeField] TMP_Text healthText;
    [SerializeField] CardSO StarterCard;


    CardSO currentCard;

    const String ENEMY_STRING = "Card";

    void Awake()
    {
        currentCard = StarterCard;
    }

    void  Start()
    {
        damageText.text = currentCard.Dmage.ToString();
        healthText.text = currentCard.Health.ToString();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit");
        if (!other.CompareTag(ENEMY_STRING)) return;
        DamageHandeller();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void DamageHandeller()
    {
        currentCard.Health -= currentCard.Dmage;

        if (currentCard.Health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
