using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeMovement : MonoBehaviour
{
    public GameObject player;

    bool movement = true;
    int movementSpeed = 50;


    private void Update()
    {
        if (movement)
        {
            transform.position += new Vector3(0, 0, -movementSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("BlockStop"))
        {
            movement = false;

            if(player.activeInHierarchy)
            {
                // Player Wins

                
            }
            else
            {
                // Player Loses

                
            }
        }
    }

}
