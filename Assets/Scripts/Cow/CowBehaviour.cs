using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CowBehaviour : MonoBehaviour
{
    public float speed;
    public GameObject moo;
    public LevelDataScriptableObject levelData;

    private void Awake()
    {
        speed = speed * levelData.speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        if (transform.position.y > 7)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Text")
        {
            levelData.succeeded = true;
            GameObject newMoo = Instantiate(moo);
            newMoo.transform.position = new Vector2(transform.position.x, 0);
        }
    }
}
