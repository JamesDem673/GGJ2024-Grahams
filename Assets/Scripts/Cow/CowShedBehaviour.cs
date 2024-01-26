using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowShedBehaviour : MonoBehaviour
{
    public GameObject cow;
    public GameObject moo;
    public float cooldown;
    bool fireable = true;
    float timer = 0;
    private void Update()
    {
        if (!fireable)
        {
            timer += Time.deltaTime;
            if (timer > cooldown)
            {
                fireable = true;
                timer = 0;
            }
        }
        else
        {
            if (Input.GetAxis("Jump") != 0)
            {
                GameObject newCow = Instantiate(cow);
                newCow.transform.position = transform.position;
                newCow.GetComponent<CowBehaviour>().moo = moo;
                fireable = false;
            }
        }
    }
}
