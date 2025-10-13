using System.Collections.Generic;
using UnityEngine;

public class CardDeckController : MonoBehaviour
{
    public List<GameObject> cardsInSlotList = new List<GameObject>();
    // adding card like this just for test*
    [SerializeField] private GameObject cardPrefab;
    [SerializeField] private Transform[] cardSlotInDeckPos;

    // singleton
    public static CardDeckController instance;
    void Awake() { instance = this; }

    void Start()
    {
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
