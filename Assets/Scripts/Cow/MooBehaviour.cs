using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MooBehaviour : MonoBehaviour
{
    float timer = 0;
    public float activeTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > activeTime)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("LevelSelect");
        }
    }
}
