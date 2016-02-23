using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartController : MonoBehaviour {

    [SerializeField]
    Button StartButton;
    [SerializeField]
    Button ExitButton;

    public void OnStartClicked()
    {
        StartButton.gameObject.SetActive(false);
        ExitButton.gameObject.SetActive(false);
    }

    public void OnExitClicked()
    {
        Application.Quit();
    }
}
