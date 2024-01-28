using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PhotoTimerScript : MonoBehaviour
{
    //public TextMeshPro poo;
    // Start is called before the first frame update
    float RemainingTime;
    string StringTimer;
    bool isOn;
    void Start()
    {
        isOn = false;
    }
    public void StartTimer(bool Start)
    {
        isOn = Start;
    }
    public void SetTimerSecondValue(float seconds)
    {
        RemainingTime = seconds;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOn)
        {
            if (RemainingTime > 0)
            {
                RemainingTime -= Time.deltaTime;
                VisualTimer(RemainingTime);
            }
            else
            {
                GetComponent<TextMeshPro>().text = "0.0000";
            }
        }
    }
    private void VisualTimer(float Time)
    {
        
        Time += 1;
        float minutes = Mathf.FloorToInt(RemainingTime / 60);
        float seconds = Mathf.FloorToInt(RemainingTime % 60);
        float miliseconds = (Time % 1) * 1000;
        if (Time > 0)
        {
            GetComponent<TextMeshPro>().text = System.Math.Round(RemainingTime, 4).ToString().PadRight(6, '0');
        }

    }
}
