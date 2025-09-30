using UnityEngine;

public class DragAndDropTest : MonoBehaviour
{
    private Vector3 offset;
    private Camera cam;

    void Awake()
    {
        cam = Camera.main;
    }

    void OnMouseDown()
    {
        Vector3 mouseWorld = cam.ScreenToWorldPoint(Input.mousePosition);
        mouseWorld.z = transform.position.z;
        offset = transform.position - mouseWorld;
    }

    void OnMouseDrag()
    {
        Vector3 mouseWorld = cam.ScreenToWorldPoint(Input.mousePosition);
        mouseWorld.z = transform.position.z;
        transform.position = mouseWorld - offset;
    }
}
