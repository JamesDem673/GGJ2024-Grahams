using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullBehaviour : MonoBehaviour
{
    Vector3 startPos;
    bool clicked = false;


    private void OnMouseDown()
    {
        clicked = true;
    }
}
