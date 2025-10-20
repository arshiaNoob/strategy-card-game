using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using TMPro;
using System.Linq;
using UnityEditor.VersionControl;

public class AccountCheck : MonoBehaviour, IPointerDownHandler
{
    public bool isAccount = false;

    [SerializeField] TMP_Text username;
    [SerializeField] TMP_Text password;
    [SerializeField] TMP_Text errorForPassword;
    [SerializeField] TMP_Text errorForUsername;
    public void OnPointerDown(PointerEventData eventData)
    {
        errorForPassword.text = "";
        errorForUsername.text = "";
        // TODO: چک کن ببینه یوزرنیم وجود داره یا نه
        if (password.text.Length < 8) { errorForPassword.text = "password Must be more than 8 character"; return; }
        if (username.text.Length <= 1){ errorForUsername.text = "You Must Write a user Name"; return; }
       
        isAccount = true;
        GoToTheMenu();
    }

    void GoToTheMenu()
    {
        if (!isAccount) return;

        SceneManager.LoadScene("Main Menu");
    }
}

