using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticMovement3D : MonoBehaviour
{
    public float staticSpeed;

    public GameObject bottomBound;
    public GameObject topBound;

    float topYval;
    float bottomYval;
    float xVal;
    float zVal;

    private void Start()
    {
        topYval = topBound.transform.position.y;
        bottomYval = bottomBound.transform.position.y;

        xVal = topBound.transform.position.x;
        zVal = topBound.transform.position.z;
    }


    private void Update()
    {
        transform.position -= new Vector3(0, Time.deltaTime * staticSpeed, 0);

        if (transform.position.y < bottomYval)
        {
            transform.position = new Vector3(xVal, topYval, zVal);
        }
    }
}

