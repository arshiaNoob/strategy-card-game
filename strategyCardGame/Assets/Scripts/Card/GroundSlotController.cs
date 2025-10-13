using System.Collections.Generic;
using UnityEngine;

public class GroundSlotController : MonoBehaviour
{
    // {0, 0, 0, 0, 0} means there is no card
    // {1, 0, 0, 0, 0} means there is one card in slot 1
    // {1, 1, 1, 1, 1} means all of slots are filled
    List<int> cardSlotsState = new List<int>() { 0, 0, 0, 0, 0 };
    [SerializeField] private GameObject[] borderObjects;

    // singleton
    public static GroundSlotController instance;
    void Awake() { instance = this; }

    public void ShowAvailableSlots()
    {
        for (int index = 0; index < cardSlotsState.Count; index++)
        {
            //  == 0 means there is no card in this slot
            if (cardSlotsState[index] == 0)
            {
                borderObjects[index].SetActive(true);
            }
        }
    }

    public void HideAllSlots()
    {
        // hide all Slot borders
        foreach (GameObject border in borderObjects)
        {
            border.SetActive(false);
        }
    }
    
    public void SetSlotIsFull(int slotNum)
    {
        cardSlotsState[slotNum] = 1;
    }
}
