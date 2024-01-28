using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleControl : MonoBehaviour
{
    public GameObject fridge;

    public GameObject section1;
    public GameObject section2;
    public GameObject section3;
    public GameObject section4;

    int SafeLane1 = 0;
    int SafeLane2 = 0;
    int SafeLane3 = 0;
    int SafeLane4 = 0;

    float Safex1;
    float Safex2;
    float Safex3;
    float Safex4;

    int block_count = 0;

    void Start()
    {
        SafeLane1 = UnityEngine.Random.Range(0, 3);

        SafeLane2 = UnityEngine.Random.Range(0, 3);

        SafeLane3 = UnityEngine.Random.Range(0, 3);

        SafeLane4 = UnityEngine.Random.Range(0, 3);



        UnityEngine.Random.InitState(DateTime.Now.TimeOfDay.Seconds);

        section1.transform.GetChild(SafeLane1).gameObject.SetActive(false);
        Safex1 = section1.transform.GetChild(SafeLane1).transform.position.x;

        section2.transform.GetChild(SafeLane2).gameObject.SetActive(false);
        Safex2 = section2.transform.GetChild(SafeLane2).transform.position.x;

        section3.transform.GetChild(SafeLane3).gameObject.SetActive(false);
        Safex3 = section3.transform.GetChild(SafeLane3).transform.position.x;

        section4.transform.GetChild(SafeLane4).gameObject.SetActive(false);
        Safex4 = section4.transform.GetChild(SafeLane4).transform.position.x;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Fridge"))
        {
            switch (block_count)
            {
                case 0:
                    fridge.transform.position = new Vector3(Safex1, fridge.transform.position.y, fridge.transform.position.z);
                    break;
                case 1:
                    fridge.transform.position = new Vector3(Safex2, fridge.transform.position.y, fridge.transform.position.z);
                    break;
                case 2:
                    fridge.transform.position = new Vector3(Safex3, fridge.transform.position.y, fridge.transform.position.z);
                    break;
                case 3:
                    fridge.transform.position = new Vector3(Safex4, fridge.transform.position.y, fridge.transform.position.z);
                    break;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Equals("Fridge"))
        {
            GetComponent<BoxCollider>().transform.position += new Vector3(0, 0, -80);
            block_count += 1;
        }
    }
}
