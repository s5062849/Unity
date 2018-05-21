using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideShow : MonoBehaviour {

    public void Hide()
    {
        
        gameObject.GetComponent<CanvasGroup>().alpha = 0f;

        gameObject.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void Show()
    {
        gameObject.GetComponent<CanvasGroup>().alpha = 1f;

        gameObject.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
