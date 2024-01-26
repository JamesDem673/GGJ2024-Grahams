using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "Level Data")]
public class LevelDataScriptableObject : ScriptableObject
{
    public float speed;
    public int score;
    public int currentLevel;
    public int lives;
}
