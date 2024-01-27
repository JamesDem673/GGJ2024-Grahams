using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndClock : MonoBehaviour
{
    public float endTimer;
    private float endTime;

    void Update()
    {
        endTime += Time.deltaTime;
        if (endTime >= endTimer)
        {
            SceneManager.LoadScene("LevelSelect");
        }
    }
}
