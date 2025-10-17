using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.EventSystems;

public class QuitButton : MonoBehaviour, IPointerDownHandler
{
    
    public void OnPointerDown(PointerEventData eventData) 
    {
        Application.Quit();
        Debug.Log("You Just Closed The Game idiot");
    }
}
