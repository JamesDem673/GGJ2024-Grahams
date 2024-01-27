using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    public float arrowSpeed;
    private float startRotation;
    private float lineRotation;

    void Start()
    {
        startRotation = transform.rotation.eulerAngles.z;
    }

    void Update()
    {
        lineRotation += Time.deltaTime;
        if (lineRotation > 360)
            lineRotation -= 360;
        Vector3 arrowMove = transform.rotation.eulerAngles;
        arrowMove.z = startRotation + Mathf.Sin(lineRotation * 2) * arrowSpeed;
        transform.rotation = Quaternion.Euler(arrowMove);
    }
}
