using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public GameObject fridge;
    public GameObject floor;

    bool movement = true;

    //a +   d -
    float targetXpos = -1000;
    float stepLength = 0.2f;
    float movementSpeed = 51.75f;

    private void Start()
    {
        transform.position = new Vector3(0, -2, 40);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (transform.position.x == -4)
            {
                targetXpos = 0;
            }
            else if (transform.position.x == 0)
            {
                targetXpos = 4;
            }
            stepLength = 0.5f;
        }


        if (Input.GetKeyDown(KeyCode.D))
        {
            if (transform.position.x == 4)
            {
                targetXpos = 0;
            }
            else if (transform.position.x == 0)
            {
                targetXpos = -4;
            }
            stepLength = -0.5f;
        }


        if (movement)
        {
            if (targetXpos == -1000 | targetXpos == transform.position.x)
            {
                transform.position += new Vector3(0, 0, -movementSpeed * Time.deltaTime);
                stepLength = 0f;
            }
            else
            {
                transform.position += new Vector3(stepLength, 0, -movementSpeed * Time.deltaTime);
            }
        }

        if (transform.position.z < -300)
        {
            floor.transform.SetParent(gameObject.transform);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Dangerzone"))
        {
            transform.GetChild(0).SetParent(null, true);
            movement = false;
            gameObject.SetActive(false);
        }

        if (other.gameObject.name.Equals("BlockStop"))
        {
            Debug.Log("End");
            floor.transform.SetParent(transform);
        }
    }
}
