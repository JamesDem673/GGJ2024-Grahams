using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    bool movement = true;

    float targetXpos = -1000;
    float stepLength = 0.5f;

    private void Update()
    {
        //a +   d -
        int movementSpeed = 50;

        if (gameObject.name.Equals("Player"))
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
        }

        if (gameObject.name.Equals("Fridge"))
        {
            if (movement)
            {
                transform.position += new Vector3(0, 0, -movementSpeed * Time.deltaTime);
            }
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Dangerzone"))
        {
            PlayerLoses(); 
        }

        if (other.gameObject.name.Equals("BlockStop"))
        {
            PlayerWins();
        }
    }

    void PlayerLoses()
    {
        transform.GetChild(0).SetParent(null, true);
        Destroy(gameObject);
    }

    void PlayerWins()
    {
        Debug.Log("Win");
        movement = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    }
}
