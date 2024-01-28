using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class FlashScript : MonoBehaviour
{
    // Start is called before the first frame update

    public void CameraFlash()
    {
        Color whiteColor = Color.white;
        gameObject.GetComponent<Image>().color = whiteColor;
        gameObject.GetComponent<Image>().CrossFadeAlpha(0, 1, false);
    }
}
