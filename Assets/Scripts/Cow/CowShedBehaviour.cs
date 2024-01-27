using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowShedBehaviour : MonoBehaviour
{
    public GameObject cow;
    public float cooldown;
    public float moveamount;
    public float movespeed;
    float startpos;
    float linepos;
    bool fireable = true;
    float timer = 0;
    public GameData levelData;

    private void Awake()
    {
        movespeed = movespeed * levelData.speed;
        startpos = transform.position.x;
    }
    private void Update()
    {
        linepos += Time.deltaTime * movespeed;
        if (linepos > 360)
            linepos -= 360;
        transform.position = new Vector3(startpos + Mathf.Sin(linepos) * moveamount, transform.position.y, 0);
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
                fireable = false;
            }
        }
    }
}
