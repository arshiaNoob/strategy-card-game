using UnityEngine;

public class SlotsCheck : MonoBehaviour
{

    [SerializeField] private string tagToFind = "Card";

    [SerializeField] GameObject borderForPutCard;
    [SerializeField] private bool includeDescendants = true;


    [ContextMenu("Check Children For Tag")]


    void Awake()
    {
        borderForPutCard.SetActive(false);
    }

    public void CheckAndAct()
    {
        bool found = includeDescendants
            ? HasChildWithTagRecursive(transform, tagToFind)
            : HasDirectChildWithTag(transform, tagToFind);

        if (!found)
        {
            PutCard();
        }
    }

    
    void Start()
    {
        CheckAndAct();
    }

    private bool HasDirectChildWithTag(Transform parent, string tagName)
    {
        foreach (Transform child in parent)
        {
            
            if (child.CompareTag(tagName))
                return true;
        }
        return false;
    }

    private bool HasChildWithTagRecursive(Transform parent, string tagName)
    {
        foreach (Transform child in parent)
        {
            if (child.CompareTag(tagName))
                return true;

            if (HasChildWithTagRecursive(child, tagName))
                return true;
        }
        return false;
    }

   
    private void PutCard()
    {
        borderForPutCard.SetActive(true);
    }
}
