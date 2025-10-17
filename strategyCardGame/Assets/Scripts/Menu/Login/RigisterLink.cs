using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class RigisterLink : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData) 
    {
        SceneManager.LoadScene("Rigister Scene");
    }
}
