using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public int playerNumber;
    public int playerNumberTurn;
    public bool canPlayerMove;

    [SerializeField] Transform shipTransform;
    [SerializeField] Vector3 shipPos1;
    [SerializeField] Vector3 shipPos2;
    [SerializeField] GameObject blueFire;
    [SerializeField] GameObject redFire;

    // singleton
    public static TurnManager instance;
    void Awake() {
        instance = this;
        // set like this just for tets*
        // we set them later with server
        SetStarterValues(1, 1, true);
    }

    private void Start()
    {
        PlayShipAnimation();
    }

    public void NextTurn()
    {
        if (playerNumberTurn == 1) playerNumberTurn = 2;
        else playerNumberTurn = 1;

        EnableOrDisablePlayer();

        PlayShipAnimation();
    }

    public void SetStarterValues(
        int _playerNumber,
        int _playerNumberTurn,
        bool _canPlayermove
    ) {
        playerNumber = _playerNumber;
        playerNumberTurn = _playerNumberTurn;
        canPlayerMove = _canPlayermove;
    }

    private void EnableOrDisablePlayer()
    {
        canPlayerMove = !canPlayerMove;
    }

    private void PlayShipAnimation()
    {
        // player turn
        if (playerNumberTurn == 1)
        {
            shipTransform.position = shipPos1;
            redFire.SetActive(false);
            blueFire.SetActive(true);
        }
        // enemy turn
        else
        {
            shipTransform.position = shipPos2;
            redFire.SetActive(true);
            blueFire.SetActive(false);
        }
    }
}
