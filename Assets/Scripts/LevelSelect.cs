using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public LevelDataScriptableObject data;
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
        int a = Random.Range(0, scenes.Length);
        print(a);
        SceneManager.LoadScene(scenes[a]);
    }
}
