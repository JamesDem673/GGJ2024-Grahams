using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandFollowMouse : MonoBehaviour
{
    // Start is called before the first frame update

    // fetch the mouse cursor
    //set the x and y of the object to the mouse cursor
    //use vector 3 to ensure the z axis does not move
    Vector3 MouseCursorPos;
    Vector3 NewObjectPos;
    public Camera Camera;


    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        MouseCursorPos = Input.mousePosition;
        NewObjectPos = Camera.ScreenToWorldPoint(MouseCursorPos);
        gameObject.transform.position = NewObjectPos;





    }
}
