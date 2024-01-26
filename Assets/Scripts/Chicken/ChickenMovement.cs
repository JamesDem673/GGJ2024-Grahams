using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMovement : MonoBehaviour
{
    private Rigidbody2D chickenBody;
    public int speed;

    private void Awake()
    {
        chickenBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        chickenBody.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "LoseCondition")
            Destroy(gameObject);
        if (collision.tag == "WinCondition")
            Debug.Log("Win!");
    }
}
