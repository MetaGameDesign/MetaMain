using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {

    public static SceneController Main;
    

    GameType type;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);

        Main = GetComponent<SceneController>();
    }

    public void SetGameType(GameType _type)
    {
        type = _type;
    }

    public GameType GetGameType()
    {
        return type;
    }

    public void SetIdentification()
    {
        type = GameType.Identification;

        MonitorMouse.Main.ActivateClaw();
    }

    public void SetDifferentiation()
    {
        type = GameType.Differentiation;
        
        MonitorMouse.Main.ActivateHand();
    }

    public void OnExitClicked()
    {
        Application.Quit();
    }
    

}
