using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AccountCheck : MonoBehaviour, IPointerDownHandler
{
    Image buttonImage;
    public bool isAccount = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        // TODO: چک کن ببینه یوزرنیم وجود داره یا نه
        isAccount = true;
        GoToTheMenu();
    }

    void GoToTheMenu()
    {
        if (!isAccount) return;

        SceneManager.LoadScene("Main Menu");
    }


}

