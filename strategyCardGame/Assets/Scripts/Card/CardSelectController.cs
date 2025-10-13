using UnityEngine;

public class CardSelectController : MonoBehaviour
{
    // we need this for attack and place cards in ground
    GameObject selectedCard;

    // singleton
    public static CardSelectController instance;
    void Awake() { instance = this; }

    public void Select(GameObject cardObj)
    {
        // make last selected card smaller
        if (selectedCard)
            selectedCard.GetComponent<CardClick>().Hidehighlight();
        
        selectedCard = cardObj;
        CardClick cardClickComponent = cardObj.GetComponent<CardClick>();
        // make card bigger
        cardClickComponent.Showhighlight();

        if (cardClickComponent.cardHasBeenPlased)
        {
            // TODO: show red border around enemy cards
            print("you selected an plased card");
        }
        else
        {
            // show available slots in ground to plase this card
            GroundSlotController.instance.ShowAvailableSlots();
        }
    }
    
    public void PlaseCard(Transform borderPos, int borderNum)
    {
        // make card smaller(it's original size)
        selectedCard.GetComponent<CardClick>().Hidehighlight();

        int cardManaAmount = selectedCard.GetComponent<CardStatus>().currentCard.Mana;
        int playerCurrentManaAmount = ManaManager.instance.currentManaAmount;
        // check if player have neede amount of mana to plase this card
        if (playerCurrentManaAmount - cardManaAmount < 0)
        {
            print("player dont have mana to plase this card");
            return;
        }
        // decrease player mana amount
        ManaManager.instance.DecreaseManaAmount(cardManaAmount);
        // plase card in this pos (change its position)
        selectedCard.transform.position = borderPos.position;
        selectedCard.GetComponent<CardClick>().cardHasBeenPlased = true;
        // hide all borders 
        GroundSlotController.instance.HideAllSlots();
        // set this slot is full in list
        GroundSlotController.instance.SetSlotIsFull(borderNum);
    }
}
