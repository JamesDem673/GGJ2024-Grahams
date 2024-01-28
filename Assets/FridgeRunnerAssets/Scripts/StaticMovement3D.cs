using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticMovement3D : MonoBehaviour
{
    public float staticSpeed;

    private void Update()
    {
        transform.position -= new Vector3(0, Time.deltaTime * staticSpeed, 0);
        if(transform.position.y < -240)
        {
            transform.position = new Vector3(transform.position.x, 972.5f, transform.position.z);
        }
    }
}
