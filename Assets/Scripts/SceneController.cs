using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {

    public static SceneController Scene;

    GameType type;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void Start()
    {
        Scene = GetComponent<SceneController>();
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
    }

    public void SetDifferentiation()
    {
        type = GameType.Differentiation;
    }

    public void OnExitClicked()
    {
        Application.Quit();
    }


}
