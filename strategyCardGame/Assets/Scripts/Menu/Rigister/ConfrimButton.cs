using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ConfrimButton : MonoBehaviour, IPointerDownHandler
{
   public void OnPointerDown(PointerEventData eventData)
    {
        //ToDo: اطلاعات اکانت رو ذخیره کنه و اگه ایمیل یا یوزر نیمی شبیه این وجود داشت اخطار بده

        SceneManager.LoadScene("Login Scene");
    }
}
