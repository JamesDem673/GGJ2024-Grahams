using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public GameData data;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI jokeText;
    public GameObject startText;

    public float jokeEndTime;
    bool jokeEndShowing = false;
    float jokeEndTimer = 0;
    bool gameOver = false;

    LevelData nextLevel;


    private void Awake()
    {
        LevelData[] levels = Resources.LoadAll<LevelData>("LevelData");

        if (data.currentLevel != -1)
        {
            jokeEndShowing = true;
            if (data.succeeded)
            {
                data.score += 100;
                data.speed += 0.5f;
                jokeText.text = levels[data.currentLevel].jokeEnd;
            }
            else
            {
                data.lives--;
                if (data.lives == 0)
                {
                    jokeEndShowing = false;
                    gameOver = true;
                    jokeText.text = "Game Over";
                    startText.SetActive(true);
                    startText.GetComponent<TextMeshProUGUI>().text = "Press Space to continue";
                }
                else
                    jokeText.text = levels[data.currentLevel].jokeFail;
            }
        }

        livesText.text = data.lives.ToString();
        scoreText.text = data.score.ToString();

        //string[] scenes = Directory.GetFiles("Assets/Scenes/Levels", "*.unity", SearchOption.TopDirectoryOnly);
        //for (int i = 0; i < scenes.Length; i++)
        //{
        //    scenes[i] = scenes[i].Replace("Assets/Scenes/Levels", "");
        //    scenes[i] = scenes[i].Remove(0,1);
        //    scenes[i] = scenes[i].Replace(".unity", "");
        //    print(scenes[i]);
        //}

        if (data.currentLevel != -1)
        {
            int currentIndex = 0;
            int removedIndex = -1;
            LevelData[] levels2 = new LevelData[levels.Length - 1];
            for (int i = 0; i < levels.Length; i++)
            {
                if (i != data.currentLevel)
                {
                    levels2[currentIndex] = levels[i];
                    currentIndex++;
                }
                else
                {
                    removedIndex = i;
                }
            }
            int a = Random.Range(0, levels2.Length);
            nextLevel = levels2[a];
            if (a >= removedIndex)
            {
                a++;
            }
            data.currentLevel = a;
        }
        else
        {
            int a = Random.Range(0, levels.Length);
            nextLevel = levels[a];
            data.currentLevel = a;
            jokeText.text = nextLevel.jokeStart;
            startText.SetActive(true);
        }
    }

    private void Update()
    {
        if (jokeEndShowing)
        {
            jokeEndTimer += Time.deltaTime;
            if (jokeEndTimer > jokeEndTime)
            {
                jokeEndShowing = false;
                jokeText.text = nextLevel.jokeStart;
                startText.SetActive(true);
            }
        }
        else
        {
            if (Input.GetAxis("Jump") != 0)
            {
                if (gameOver)
                    SceneManager.LoadScene("TitleScreen");
                else
                    SceneManager.LoadScene(nextLevel.sceneName);
            }
        }
    }
}
