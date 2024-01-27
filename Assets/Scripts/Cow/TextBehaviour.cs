using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBehaviour : MonoBehaviour
{
    public float speed;
    public LevelDataScriptableObject levelData;
    // Start is called before the first frame update
    void Start()
    {
        speed = speed * levelData.speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
