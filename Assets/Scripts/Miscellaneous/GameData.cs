using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "Game Data")]
public class GameData : ScriptableObject
{
    public float speed;
    public int score;
    public int currentLevel;
    public int lives;
    public bool succeeded;
}
