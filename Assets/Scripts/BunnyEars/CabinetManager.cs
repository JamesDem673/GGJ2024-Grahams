using System.Collections;
using System.Collections.Generic;
using System.Timers;
using TMPro;
using UnityEngine;

public class CabinetManager : MonoBehaviour
{


    public GameObject Hand;
    public GameObject PhotoPrefab;
    public Transform Canvas;
    public GameObject UpButton;
    public GameObject DownButton;
    public GameObject LeftButton;
    public GameObject RightButton;
    public Transform FlashScript;
    public TextMeshPro TimerPhotoText;
    public float TimeMax;
    public GameObject HandTarget;
    public Transform ThumbUI;
    float Timer;
    bool AddPhoto = false;
    bool PhotoAdded = false;
    bool ButtonLock;
    bool hasWon;
    bool TimerStarted = false;

    public GameData data;
    // Start is called before the first frame update
    void Start()
    {
        TimeMax -= (data.speed / 2);
        TimerPhotoText.GetComponent<PhotoTimerScript>().SetTimerSecondValue(TimeMax);
    }

    // Update is called once per frame
    void Update()
    {
        if (AddPhoto)
        {
            Instantiate(PhotoPrefab, Canvas);
            FlashScript.GetComponent<FlashScript>().CameraFlash();
            PhotoAdded = true;
            AddPhoto = false;
            UpButton.GetComponent<CabinetButtonBehaviour>().SetButtonLock(true);
            DownButton.GetComponent<CabinetButtonBehaviour>().SetButtonLock(true);
            LeftButton.GetComponent<CabinetButtonBehaviour>().SetButtonLock(true);
            RightButton.GetComponent<CabinetButtonBehaviour>().SetButtonLock(true);
            if (HandTarget.GetComponent<HandTargetScript>().GetWinCondition())
            {
                hasWon = true;
                ThumbUI.GetComponent<ThumbsWinScript>().SetWin(true);
                data.succeeded = true;
            }
            else
            {
                hasWon = false;
                ThumbUI.GetComponent<ThumbsWinScript>().SetWin(false);
                data.succeeded = false;
            }

        }
        if (!TimerStarted)
        {
            TimerPhotoText.GetComponent<PhotoTimerScript>().StartTimer(true);
            TimerStarted = true;
        }
        Timer += Time.deltaTime;

        if (Timer > TimeMax)
        {
            if (!PhotoAdded)
            {
                AddPhoto = true;
            }

        }
        else
        {

        }
    }

    public void MoveHandUp()
    {
        Hand.GetComponent<HandMovement>().MoveHandUp();
    }
    
    public void MoveHandLeft()
    {
      Hand.GetComponent<HandMovement>().MoveHandLeft();
    }

    public void MoveHandDown()
    {
        Hand.GetComponent<HandMovement>().MoveHandDown();
    }

    public void MoveHandRight()
    {
        Hand.GetComponent<HandMovement>().MoveHandRight();
    }


}
