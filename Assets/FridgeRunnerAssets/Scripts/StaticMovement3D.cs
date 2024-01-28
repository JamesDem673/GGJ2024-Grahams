using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticMovement3D : MonoBehaviour
{
    public float staticSpeed;

    private void Update()
    {
        transform.position -= new Vector3(0, Time.deltaTime * staticSpeed, 0);

        if (transform.position.y < -242.0417)
        {
            transform.position = new Vector3(735, 970.7084f, 0);
        }
    }
}



//bottom -242.0417
//top 970.7084
//x 735
//z 0