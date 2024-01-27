using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Losing : MonoBehaviour
{
    public GameObject loss;
    public RopeMovement rope;
    public GameData levelData;

    public void SuspenseLoss()
    {
        loss.SetActive(true);
        rope.burnSpeed = 0;
        levelData.succeeded = false;
    }
}
