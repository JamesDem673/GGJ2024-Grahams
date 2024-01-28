using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float MoveStep = 0.03f;
    public GameData data;
    void Start()
    {
        MoveStep = MoveStep * data.speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveHandUp()
    {
        if (gameObject.transform.position.y < 139.08)
        {
            float currentValue = gameObject.transform.position.y;

            gameObject.transform.position = new Vector3(gameObject.transform.position.x, currentValue + (MoveStep * Time.deltaTime), gameObject.transform.position.z);
        }
        // increase the Y value of the gameobject
        
    }

    public void MoveHandLeft()
    {
        if (gameObject.transform.position.x > -1.77 && gameObject.transform.position.z >0.06 )
        {
            float CurrentValuex = gameObject.transform.position.x;
            float CurrentValuez = gameObject.transform.position.z;

            gameObject.transform.position = new Vector3(CurrentValuex - (MoveStep * Time.deltaTime), gameObject.transform.position.y, CurrentValuez - (MoveStep * Time.deltaTime));
        }
    }

    public void MoveHandDown()
    {
        if (gameObject.transform.position.y > 131.35)
        {
            float CurrentValue = gameObject.transform.position.y;

            gameObject.transform.position = new Vector3(gameObject.transform.position.x, CurrentValue - (MoveStep * Time.deltaTime), gameObject.transform.position.z);
        }
        
    }

    public void MoveHandRight()
    {
        if (gameObject.transform.position.x < 0.79 && gameObject.transform.position.z < 2.95)
        {
            float CurrentValuex = gameObject.transform.position.x;
            float CurrentValuez = gameObject.transform.position.z;

            gameObject.transform.position = new Vector3(CurrentValuex + (MoveStep * Time.deltaTime), gameObject.transform.position.y, CurrentValuez + (MoveStep * Time.deltaTime));
        }
    }
}
