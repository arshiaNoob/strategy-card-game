using UnityEngine;

public class Spaceship : MonoBehaviour
{
    void OnMouseDown()
    {
        if (!TurnManager.instance.canPlayerMove) return;

        CardSelectController.instance.DeselectCard();
        // next turn
        TurnManager.instance.NextTurn();
    }
}
