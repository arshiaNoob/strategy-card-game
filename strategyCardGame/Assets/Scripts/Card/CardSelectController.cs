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
        if (!TurnManager.instance.canPlayerMove) return;

        // make last selected card smaller
        if (selectedCard)
            selectedCard.GetComponent<CardClick>().Hidehighlight();
        
        selectedCard = cardObj;
        CardClick cardClickComponent = cardObj.GetComponent<CardClick>();
        // make card bigger
        cardClickComponent.Showhighlight();

        if (cardClickComponent.cardHasBeenPlased)
        {
            print("you selected an plased card");
            // TODO: show red border around enemy cards
            // bug fix: hide ground slot borders
            GroundSlotController.instance.HideAllSlots();
        }
        else
        {
            // show available slots in ground to plase this card
            if (PlayerHaveNeededManaAmount())
                GroundSlotController.instance.ShowAvailableSlots();
            // don't show slots if player dont have needed amount of mana
            else GroundSlotController.instance.HideAllSlots();
        }
    }

    public void PlaseCard(Transform borderPos, int borderNum)
    {
        if (!TurnManager.instance.canPlayerMove) return;

        if (!PlayerHaveNeededManaAmount()) return;
        // decrease player mana amount
        int cardManaAmount = selectedCard.GetComponent<CardStatus>().currentCard.Mana;
        ManaManager.instance.DecreaseManaAmount(cardManaAmount);
        // plase card in this pos (change its position)
        selectedCard.transform.position = borderPos.position;
        selectedCard.GetComponent<CardClick>().cardHasBeenPlased = true;
        // hide card mana border
        selectedCard.GetComponent<CardStatus>().CardManaBorder.SetActive(false);
        // set this slot is full in list
        GroundSlotController.instance.SetSlotIsFull(borderNum);

        DeselectCard();
    }

    private bool PlayerHaveNeededManaAmount()
    {
        int cardManaAmount = selectedCard.GetComponent<CardStatus>().currentCard.Mana;
        int playerCurrentManaAmount = ManaManager.instance.currentManaAmount;
        // check if player have needed amount of mana to plase this card
        if (playerCurrentManaAmount - cardManaAmount < 0)
        {
            print("player dont have mana to plase this card");
            return false;
        }
        return true;
    }
    
    public void DeselectCard()
    {
        // hide all borders 
        GroundSlotController.instance.HideAllSlots();
        // make card smaller(it's original size)
        if(selectedCard)
        selectedCard.GetComponent<CardClick>().Hidehighlight();
        selectedCard = null;
    }
}
