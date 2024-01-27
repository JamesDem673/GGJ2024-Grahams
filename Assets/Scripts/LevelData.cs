using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Level Data")]
public class LevelData : ScriptableObject
{
    public string sceneName;
    public string jokeStart;
    public string jokeEnd;
}
