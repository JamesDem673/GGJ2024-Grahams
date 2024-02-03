using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInteractive : MonoBehaviour
{
    // Start is called before the first frame update

    // fetch the mouse cursor
    //set the x and y of the object to the mouse cursor
    //use vector 3 to ensure the z axis does not move
    Vector2 MouseCursorPos;
    float MousePosX;
    float MousePosY;
    Vector3 NewObjectPos;
    Vector3 point;
    public Camera Camera;


    void Start()
    {
        Event current = Event.current;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MouseCursorPos.x = Camera.pixelWidth - Input.mousePosition.x;
            MouseCursorPos.y = Camera.pixelHeight - Input.mousePosition.y;


            point = Camera.ScreenToWorldPoint(new Vector3(MouseCursorPos.x, MouseCursorPos.y, Camera.transform.position.z));
            MousePosX = MouseCursorPos.x;
            MousePosY = MouseCursorPos.y;
            point.z = gameObject.transform.position.z;

            gameObject.transform.position = point;
        }
    }
}
