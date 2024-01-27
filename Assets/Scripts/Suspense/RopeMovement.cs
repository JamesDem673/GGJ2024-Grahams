using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeMovement : MonoBehaviour
{
    public GameObject rope;
    public float burnSpeed;
    public LevelDataScriptableObject levelData;

    // Start is called before the first frame update
    void Start()
    {
        burnSpeed = burnSpeed * levelData.speed;
    }

    // Update is called once per frame
    void Update()
    {
        rope.transform.position += new Vector3(0, -Time.deltaTime * burnSpeed, 0);
    }
}
