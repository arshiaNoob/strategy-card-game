using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DeckButton : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        SceneManager.LoadScene("DeckScene");
    }
}
