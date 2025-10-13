using UnityEngine;

public class Border : MonoBehaviour
{
    public int borderNumberInSlotList;
    void OnMouseDown()
    {
        CardSelectController.instance.PlaseCard(transform, borderNumberInSlotList);
    }
}
