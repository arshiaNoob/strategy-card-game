using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ConfrimButton : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] TMP_Text[] username;
    [SerializeField] TMP_Text[] password;
    [SerializeField] TMP_Text errorForUsername;
    [SerializeField] TMP_Text errorForPassword;

   public void OnPointerDown(PointerEventData eventData)
    {
        errorForPassword.text = "";
        errorForUsername.text = "";

        //ToDo: اطلاعات اکانت رو ذخیره کنه و اگه ایمیل یا یوزر نیمی شبیه این وجود داشت اخطار بده

        for (int i = 0; i < username.Length; i++)
        {
            if (username[i].text.Length <= 1) { errorForUsername.text = "You Must Write a user Name"; return; }
        }
        for (int i = 0; i < password.Length; i++)
        {
            if (password[i].text.Length <= 1) { errorForPassword.text = "password Must be more than 8 character"; return; }
        }

        SceneManager.LoadScene("Login Scene");
    }
}
