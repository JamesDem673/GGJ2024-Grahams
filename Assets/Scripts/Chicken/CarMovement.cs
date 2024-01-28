using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    private Rigidbody2D carBody;
    public float carSpeed;
    public GameData levelData;

    private void Awake()
    {
        carBody = GetComponent<Rigidbody2D>();
        carSpeed = carSpeed * levelData.speed * 0.7f;
        carBody.velocity = new Vector2(0, carSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bounds")
        {
            carBody.velocity = -carBody.velocity;
            transform.localScale = -transform.localScale;
        }
    }
}
