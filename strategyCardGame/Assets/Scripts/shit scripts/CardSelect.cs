using UnityEngine;

public class CardSelect : MonoBehaviour
{
    [SerializeField] GameObject selectBorder;

    private Vector3 defaultPostion;
    private Vector3 originalScale;
    private static CardSelect cardSelect;

    SlotsCheck slotsCheck;

    void Start()
    {
        originalScale = transform.localScale;
        defaultPostion = transform.position;
        slotsCheck = FindAnyObjectByType<SlotsCheck>();
    }

    void OnMouseDown()
    {
        // اگه یه آبجکت دیگه از قبل سلکت شده، ریستش کن
        if (cardSelect != null && cardSelect != this)
        {
            cardSelect.Deselect();
        }

        // اگه خودمون سلکت نیستیم، سلکتمان کن
        if (cardSelect != this)
        {
            Select();
        }
        else
        {
            Deselect();
        }
    }

    void Select()
    {
        transform.localScale = originalScale * 1.1f; // بزرگ‌تر شدن
        cardSelect = this;
        slotsCheck.enabled = true;
        
    }

    void Deselect()
    {
        transform.localScale = originalScale; // برگرد به حالت عادی
        transform.position = defaultPostion;
        if (cardSelect == this)
        {
            cardSelect = null;
            slotsCheck.enabled = false;
        }
    }
}
