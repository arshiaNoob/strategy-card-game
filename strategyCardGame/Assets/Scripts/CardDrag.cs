using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))]
public class CardDrag : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    private Rigidbody2D rb;
    private Camera cam;
    private Vector3 offset;
    private bool isDragging;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Vector3 worldPos = cam.ScreenToWorldPoint(eventData.position);
        worldPos.z = transform.position.z;
        offset = transform.position - worldPos;
        isDragging = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!isDragging) return;

        Vector3 worldPos = cam.ScreenToWorldPoint(eventData.position);
        worldPos.z = transform.position.z;

        // به‌جای تغییر مستقیم transform، از MovePosition استفاده می‌کنیم
        rb.MovePosition(worldPos + offset);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isDragging = false;
    }
}
