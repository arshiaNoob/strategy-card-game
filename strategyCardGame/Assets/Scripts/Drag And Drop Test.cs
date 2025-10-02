using UnityEngine;

public class DragAndDropTest : MonoBehaviour
{
    private Vector3 offset;
    private Camera cam;

    Vector3 defaultPostion;

    void Awake()
    {
        defaultPostion = transform.position;
        cam = Camera.main;
    }

    void OnMouseDown()
    {
        Vector3 mouseWorld = cam.ScreenToWorldPoint(Input.mousePosition);
        mouseWorld.z = transform.position.z;
        offset = this.transform.position - mouseWorld;
    }

    void OnMouseDrag()
    {

        Vector3 mouseWorld = cam.ScreenToWorldPoint(Input.mousePosition);
        mouseWorld.z = transform.position.z;
        this.transform.position = mouseWorld + offset;

        // if (true)
        // {
        //     Invoke("CardHandeler", 1);
        // }

    }

    void CardHandeler()
    {
        this.transform.position = defaultPostion;
    }
}
