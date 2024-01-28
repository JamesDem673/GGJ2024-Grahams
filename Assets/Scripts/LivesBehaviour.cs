using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LivesBehaviour : MonoBehaviour
{
    public GameData levelData;
    public GameObject L1;
    public GameObject L2;
    public GameObject L3;
    public GameObject L4;

    void Update()
    {
        if (levelData.lives == 3)
            L4.SetActive(false);
        if (levelData.lives == 2)
        {
            L4.SetActive(false);
            L3.SetActive(false);
        }
        if (levelData.lives == 1)
        {
            L4.SetActive(false);
            L3.SetActive(false);
            L2.SetActive(false);
        }
        if (levelData.lives == 0)
        {
            L4.SetActive(false);
            L3.SetActive(false);
            L2.SetActive(false);
            L1.SetActive(false);
        }
    }
}
