using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBehaviour : MonoBehaviour
{
    public LevelDataScriptableObject levelData;
    public int startSpeed;
    public int startLives;

    // Start is called before the first frame update
    void Start()
    {
        levelData.speed = startSpeed;
        levelData.score = 0;
        levelData.currentLevel = -1;
        levelData.lives = startLives;
        levelData.succeeded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Jump") != 0)
        {
            SceneManager.LoadScene("LevelSelect");
        }
    }
}
