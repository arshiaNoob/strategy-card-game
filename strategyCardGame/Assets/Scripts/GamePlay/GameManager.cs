using UnityEngine;

public class GameManager : MonoBehaviour
{
    // singleton
    public static GameManager instance;
    void Awake() { instance = this; }

    public bool canPlayerMove = true;

    public void EnablePlayer()
    {
        print("player can act");
    }
    
    public void DisablePlayer()
    {
        
    }
}
