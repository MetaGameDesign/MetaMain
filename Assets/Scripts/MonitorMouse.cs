using UnityEngine;
using System.Collections;

public class MonitorMouse : MonoBehaviour {

    [SerializeField] Texture2D mouseClaw;
    [SerializeField] Texture2D mouseHand;
    [SerializeField] Texture2D mouseClosedHand;
    
    Texture2D selectedState;

    public static MonitorMouse Main;

    void Awake()
    {
        Main = GetComponent<MonitorMouse>();
    }

    void SetCursor(Texture2D texture, Vector2 center)
    {
        Cursor.SetCursor(texture, center, CursorMode.Auto);
    }

    public void ActivateClaw()
    {
        selectedState = mouseClaw;
        Cursor.SetCursor(selectedState, Vector2.zero, CursorMode.Auto);
    }

    public void ActivateClosedHand()
    {
        selectedState = mouseClosedHand;
        Cursor.SetCursor(selectedState, Vector2.zero, CursorMode.Auto);
    }

    public void ActivateHand()
    {
        selectedState = mouseHand;
        Cursor.SetCursor(selectedState, Vector2.zero, CursorMode.Auto);
    }
 
}


