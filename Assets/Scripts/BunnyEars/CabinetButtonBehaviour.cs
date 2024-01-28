using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class CabinetButtonBehaviour : MonoBehaviour
{
    //Up = 1, Down = 2, Left = 3 , Right = 4
    public int ButtonConfig;
    public GameObject CabinetManagerObject;
    bool isOn = false;
    bool ButtonLock;
    // Start is called before the first frame update
    Vector3 startingPos;
    
    void Start()
    {
        startingPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(isOn)
        {
            if (!ButtonLock)
            {
                switch (ButtonConfig)
                {
                    case 1:
                        CabinetManagerObject.GetComponent<CabinetManager>().MoveHandUp();
                        break;
                    case 2:
                        CabinetManagerObject.GetComponent<CabinetManager>().MoveHandDown();
                        break;
                    case 3:
                        CabinetManagerObject.GetComponent<CabinetManager>().MoveHandLeft();
                        break;
                    case 4:
                        CabinetManagerObject.GetComponent<CabinetManager>().MoveHandRight();
                        break;
                }
            }
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 Pos = gameObject.transform.position;
            Pos.y = gameObject.transform.position.y - 0.29f;
            gameObject.transform.position = Pos;
            isOn = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            gameObject.transform.position = startingPos;
            isOn = false;
        }

    }

    public void SetButtonLock(bool Locked)
    {
        ButtonLock = Locked;
    }

    private void OnMouseExit()
    {
        if (isOn)
        {
            gameObject.transform.position = startingPos;
            isOn = false;
        }
    }
}
