using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTargetScript : MonoBehaviour
{
    bool IsWon;

    private void OnTriggerEnter(Collider collision)
    {
        IsWon = true;
    }

    private void OnTriggerExit(Collider other)
    {
        IsWon = false;
    }

    public bool GetWinCondition()
    {
        return IsWon;
    }
}
