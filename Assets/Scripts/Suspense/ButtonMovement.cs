using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMovement : MonoBehaviour
{
    public float buttonSpeed;
    private float startPosition;
    private float linePosition;

    void Start()
    {
        startPosition = transform.position.y;
    }

    void Update()
    {
        linePosition += Time.deltaTime;
        if (linePosition > 360)
            linePosition -= 360;
        transform.position = new Vector3(transform.position.x, startPosition + Mathf.Sin(linePosition) * buttonSpeed,  0);
    }
}
