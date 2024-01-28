using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticMovement3D : MonoBehaviour
{
    public float staticSpeed;

    private void Update()
    {
        transform.position -= new Vector3(0, Time.deltaTime * staticSpeed, 0);
    }
}
