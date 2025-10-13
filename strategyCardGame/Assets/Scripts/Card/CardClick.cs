using UnityEngine;

public class CardClick : MonoBehaviour
{
    // if this is enemy card set it true
    [SerializeField] bool isEnemyCard;
    // true: card has been plased in ground(is not in deck)
    public bool cardHasBeenPlased = false;

    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    // Card Click check
    void OnMouseDown()
    {
        if (!isEnemyCard)
        {
            CardSelectController.instance.Select(this.gameObject);
        }
        else
        {
            // TODO: if an card is selected attack to this
            print("this is enemy card");
        }
    }

    public void Showhighlight()
    {
        transform.localScale = originalScale * 1.1f;
    }
    
    public void Hidehighlight()
    {
        transform.localScale = originalScale;
    }
}
