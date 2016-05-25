using UnityEngine;
using System.Collections;

public class OnHoverEnlarge : MonoBehaviour {

    [SerializeField]
    private float scaleIncrease = 2f;
    [SerializeField]
    private float originalScale = 1f;

    bool isHoverActive = false;

    public void SetHoverActive()
    {
        isHoverActive = true;
    }

    public void SetHoverInactive()
    {
        AdjustScale(originalScale);

        isHoverActive = false;
    }

    void OnMouseOver()
    {
        if (isHoverActive)
        {
            AdjustScale(scaleIncrease);

            if (SceneController.Main.GetGameType() == GameType.Identification)
                MonitorMouse.Main.ActivateClaw();
            else
                MonitorMouse.Main.ActivateClosedHand();
        } else
        {
            if (SceneController.Main.GetGameType() == GameType.Identification)
                MonitorMouse.Main.ActivateClaw();
            else
                MonitorMouse.Main.ActivateHand();
        }
            
    }

    void OnMouseExit()
    {
        if (isHoverActive)
        {
            AdjustScale(originalScale);

            if (SceneController.Main.GetGameType() == GameType.Identification)
                MonitorMouse.Main.ActivateClaw();
            else
                MonitorMouse.Main.ActivateHand();

        } else
        {
            if (SceneController.Main.GetGameType() == GameType.Identification)
                MonitorMouse.Main.ActivateClaw();
            else
                MonitorMouse.Main.ActivateHand();
        }
            
    }
    
    void AdjustScale(float amt)
    {
        transform.localScale = new Vector3(amt, amt, 0f);
    }
}
