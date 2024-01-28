using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FridgeMovement : MonoBehaviour
{
    public GameObject player;

    public GameData data;

    bool movement = true;
    float movementSpeed = 50;


    private void Start()
    {
        movementSpeed *= data.speed;
        transform.position += new Vector3(0, 0, movementSpeed * 2);
    }

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

            if (player.activeInHierarchy)
            {
                // Player Wins
                data.succeeded = true;
            }
            else
            {
                // Player Loses
                data.succeeded = false;
            }
            SceneManager.LoadScene("LevelSelect");
        }
    }

}
