using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTargetScript : MonoBehaviour
{
    // Start is called before the first frame update
    bool IsWon;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Clookie");
        IsWon = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("No Clookie");
        IsWon = false;
    }

    public bool GetWinCondition()
    {
        return IsWon;
    }
}
