using System.Collections.Generic;
using UnityEngine;

public class SlotsCheck : MonoBehaviour
{
    public List<GameObject> cardSlots = new List<GameObject>();
    public List<GameObject> border = new List<GameObject>();
    
    [SerializeField] GameObject cardPrefab;
    [SerializeField] GameObject borderForCard;
    
    CardSelect cardSelect;
    
    void Awake()
    {
        this.enabled = false;
    }

    void OnEnable()
    {
        //deleting border for clearing
        //TODO:delet border of that slot when card is on it
        border.ForEach(Destroy);
        border.Clear();

        cardSelect = FindAnyObjectByType<CardSelect>();


        if (cardSelect == null) return;

        //check for slots child
        if (!cardPrefab.transform.IsChildOf(this.transform))
        {
            foreach (GameObject cardSlot in cardSlots)
            {
                border.Add(Instantiate(borderForCard, cardSlot.transform.position, Quaternion.identity));
                Debug.Log(border.Count);
            }
        }
        else
        {
            this.enabled = false;
        }
    }
}
