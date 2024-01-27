using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextBehaviour : MonoBehaviour
{
    public float speed;
    public LevelDataScriptableObject levelData;
    // Start is called before the first frame update
    void Start()
    {
        speed = speed * levelData.speed;

        transform.position += new Vector3(-Random.Range(0f,8f * speed), 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        if (transform.position.x > 8)
        {
            levelData.succeeded = false;
            SceneManager.LoadScene("LevelSelect");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
