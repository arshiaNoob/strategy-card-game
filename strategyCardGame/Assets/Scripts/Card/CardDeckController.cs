using System.Collections.Generic;
using UnityEngine;

public class CardDeckController : MonoBehaviour
{
    List<GameObject> cardsInDeckList = new List<GameObject>();
    List<GameObject> cardsInSlotList = new List<GameObject>();
    // adding card like this just for test*
    [SerializeField] private GameObject cardPrefab;
    [SerializeField] private Transform[] cardSlotInDeckPos;

    void Start()
    {
        // adding cards to deck list just for test*
        for (int i = 0; i < 10; i++)
        {
            cardsInDeckList.Add(cardPrefab);
        }

        ShowCardsInDeckSlot();
    }
    
    private void ShowCardsInDeckSlot()
    {
        // show cards in deck slot
        foreach(Transform slotPos in cardSlotInDeckPos)
        {
            // TODO: select cards randomly in deck
            // selecting like this just for test*
            GameObject selectedCard = cardPrefab;

            // create an card in deck slot
            GameObject newCard =
                Instantiate(selectedCard, slotPos.position, Quaternion.identity);

            // adding newcard to cardsInSlotList for more controll
            cardsInSlotList.Add(newCard);
        }
    }
}
