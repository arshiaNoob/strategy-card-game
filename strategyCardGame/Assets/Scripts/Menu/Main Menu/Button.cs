using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Button : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Image buttonImage;

    Vector3 defaultScale;

    void Start()
    {
        buttonImage = GetComponent<Image>();
        defaultScale = this.transform.localScale;
    }

    
    public void OnPointerEnter(PointerEventData eventData)
    {
        Vector3 newScale = defaultScale * 1.1f;
        this.transform.localScale = newScale;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        this.transform.localScale = defaultScale;
    }


}
