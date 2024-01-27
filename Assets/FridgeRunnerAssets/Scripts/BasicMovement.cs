using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    bool movement = true;

    private void Update()
    {
        //a +   d -
        float x_movement = 0;
        int strafeSpeed = 4;
        int movementSpeed = 50;

        if (gameObject.name.Equals("Player"))
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                x_movement = strafeSpeed;
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                x_movement = -strafeSpeed;
            }


            if (movement)
            {
                transform.position += new Vector3(x_movement, 0, -movementSpeed * Time.deltaTime);

                if(transform.position.x > 6 || transform.position.x < -6)
                {
                    GetComponent<Rigidbody>().useGravity = true;
                    GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
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
        movement = false;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    }
}
