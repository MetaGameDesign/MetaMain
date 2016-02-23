using UnityEngine;
using System.Collections;

public class OnHoverEnlarge : MonoBehaviour {

    bool isHoverActive = false;

    public void SetHoverActive()
    {
        isHoverActive = true;
    }

    void OnMouseOver()
    {
        if (isHoverActive)
            AdjustScale(2f);
    }

    void OnMouseExit()
    {
        if (isHoverActive)
            AdjustScale(1f);
    }

    void AdjustScale(float amt)
    {
        transform.localScale = new Vector3(amt, amt, 0f);
    }
}
