using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;

public class RopeMovement : MonoBehaviour
{
    public GameObject rope;
    public GameObject winText;
    public Button button;
    public float burnSpeed;
    public GameData levelData;

    void Start()
    {
        burnSpeed = burnSpeed / levelData.speed;
    }

    void Update()
    {
        rope.transform.position += new Vector3(0, -Time.deltaTime * burnSpeed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bounds")
        {
            burnSpeed = 0;
            winText.SetActive(true);
            button.interactable = !button.interactable;
            levelData.succeeded = true;
        }
    }
}
