using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    private Rigidbody2D carBody;
    public int carSpeed;

    private void Awake()
    {
        carBody = GetComponent<Rigidbody2D>();
        carBody.velocity = new Vector2(0, carSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "CarBounds")
            carBody.velocity = -carBody.velocity;
    }
}
