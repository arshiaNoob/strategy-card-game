using Unity.VisualScripting;
using UnityEngine;

public class DragAndDropTest : MonoBehaviour
{
    private Vector3 offset;
    private Camera cam;

    Vector3 defaultPostion;
    Vector3 defaultScale;

    void Awake()
    {
        defaultPostion = transform.position;
        defaultScale = transform.localScale;
        cam = Camera.main;
    }

    void OnMouseDown()
    {
        Vector3 mouseWorld = cam.ScreenToWorldPoint(Input.mousePosition);
        mouseWorld.z = transform.position.z;
        offset = this.transform.position - mouseWorld;
        Vector3 selectedCardSize = defaultScale * 1.1f;
        this.transform.localScale = selectedCardSize;
    }

    void OnMouseDrag()
    {

        Vector3 mouseWorld = cam.ScreenToWorldPoint(Input.mousePosition);
        mouseWorld.z = transform.position.z;
        this.transform.position = mouseWorld + offset;

        if (true)
        {
            Invoke("CardHandeler", 5);
        }

    }

    void OnMouseUp()
    {
        this.transform.localScale = defaultScale;   
    }

    void CardHandeler()
    {
        this.transform.position = defaultPostion;
    }
}
