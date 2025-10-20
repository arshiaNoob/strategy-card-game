using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class CardManager : MonoBehaviour
{
    [SerializeField] GameObject cardPrefab;
    [SerializeField] Transform slots;
    [SerializeField] float xSpacing = 5f;
    public List<CardSO> cardsStatus = new List<CardSO>();

    CardStatus cardStatus;

    void Start()
    {
        for (int i = 0; i < cardsStatus.Count; i++)
        {
          
            Vector3 newPos = slots.position + new Vector3(i * xSpacing, 0f, 0f);
            
            GameObject newCard = Instantiate(cardPrefab, newPos, Quaternion.identity, slots);

            CardStatus status = newCard.GetComponent<CardStatus>();

            if (status != null)
            {
                status.AddStatus(cardsStatus[i]);
            }
        }
    }
}
