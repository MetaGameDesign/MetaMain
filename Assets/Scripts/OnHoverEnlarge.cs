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
            AdjustScale(scaleIncrease);
    }

    void OnMouseExit()
    {
        if (isHoverActive)
            AdjustScale(originalScale);
    }

    void AdjustScale(float amt)
    {
        transform.localScale = new Vector3(amt, amt, 0f);
    }
}
