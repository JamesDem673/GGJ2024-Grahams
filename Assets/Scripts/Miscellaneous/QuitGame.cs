using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            // UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
