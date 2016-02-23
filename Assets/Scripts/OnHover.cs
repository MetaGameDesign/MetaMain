using UnityEngine;
using System.Collections;

public class OnHover : MonoBehaviour {

    bool isHoverActive = false;

    public void SetHoverActive()
    {
        isHoverActive = true;
    }

    void OnMouseOver()
    {
        if (isHoverActive)
            AdjustAlpha(0.5f);
    }

    void OnMouseExit()
    {
        if (isHoverActive)
            AdjustAlpha(1f);
    }

    void AdjustAlpha (float amt)
    {
        Color clr = GetComponent<SpriteRenderer>().color;
        clr.a = amt;
        GetComponent<SpriteRenderer>().color = clr;
    }
}
