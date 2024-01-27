using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticMovement : MonoBehaviour
{
    public float staticSpeed;

    void Update()
    {
        transform.position -= new Vector3(0, Time.deltaTime * staticSpeed);
        if (transform.position.y < -8.2825)
            transform.position = new Vector2(transform.position.x, 8);
    }
}
