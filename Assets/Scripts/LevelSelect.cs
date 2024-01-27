using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public LevelDataScriptableObject data;
    string nextLevel;
    private void Awake()
    {
        string[] scenes = Directory.GetFiles("Assets/Scenes/Levels", "*.unity", SearchOption.TopDirectoryOnly);
        for (int i = 0; i < scenes.Length; i++)
        {
            scenes[i] = scenes[i].Replace("Assets/Scenes/Levels", "");
            scenes[i] = scenes[i].Remove(0,1);
            scenes[i] = scenes[i].Replace(".unity", "");
            print(scenes[i]);
        }

        if (data.currentLevel != -1)
        {
            int currentIndex = 0;
            int removedIndex = -1;
            string[] scenes2 = new string[scenes.Length - 1];
            for (int i = 0; i < scenes.Length; i++)
            {
                if (i != data.currentLevel)
                {
                    scenes2[currentIndex] = scenes[i];
                    currentIndex++;
                }
                else
                {

                }
            }
            int a = Random.Range(0, scenes2.Length);
            print(a);
            nextLevel = scenes2[a];
            if (a >= removedIndex)
            {
                a++;
            }
            data.currentLevel = a;
        }
        else
        {
            int a = Random.Range(0, scenes.Length);
            print(a);
            nextLevel = scenes[a];
            data.currentLevel = a;
        }
    }

    private void Update()
    {
        if (Input.GetAxis("Jump") != 0)
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
}
