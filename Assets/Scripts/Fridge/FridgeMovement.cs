using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeMovement : MonoBehaviour
{
    public GameObject player;

    public GameObject loss_text;
    public GameObject win_text;
    public GameData data;

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
                data.succeeded = true;
                win_text.SetActive(true);
            }
            else
            {
                // Player Loses
                data.succeeded = false;
                loss_text.SetActive(true);
            }
        }
    }

}
