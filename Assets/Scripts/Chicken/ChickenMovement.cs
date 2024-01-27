using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMovement : MonoBehaviour
{
    private Rigidbody2D chickenBody;
    public float chickenSpeed;
    public LevelDataScriptableObject levelData;

    private void Awake()
    {
        chickenBody = GetComponent<Rigidbody2D>();
        chickenSpeed = (float)(chickenSpeed * (levelData.speed / 1.5));
    }

    private void Update()
    {
        chickenBody.velocity = new Vector2(Input.GetAxis("Horizontal") * chickenSpeed, Input.GetAxis("Vertical") * chickenSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "LoseCondition")
            Destroy(gameObject);
        if (collision.tag == "WinCondition")
            Debug.Log("Win!");
    }
}
