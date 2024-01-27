using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullBehaviour : MonoBehaviour
{
    Vector3 startPos;
    bool clicked = false;
    public float range;
    public Camera cam;


    private void Start()
    {
        startPos = transform.position;
    }

    private void OnMouseDown()
    {
        clicked = true;
    }

    private void Update()
    {
        if (clicked && Input.GetMouseButtonUp(0))
        {
            clicked=false;
            GetComponent<Rigidbody2D>().gravityScale = 1;
            GetComponent<Rigidbody2D>().AddForce((startPos - transform.position) * 5, ForceMode2D.Impulse);
        }
    }
    private void LateUpdate()
    {
        if (clicked)
        {
            transform.position = cam.ScreenToWorldPoint(Input.mousePosition);
            transform.position += new Vector3(0,0,10);
            if ((transform.position - startPos).magnitude > range)
            {
                Vector3 difference = transform.position - startPos;
                transform.position = startPos + difference.normalized * range;
            }
        }
    }
}
