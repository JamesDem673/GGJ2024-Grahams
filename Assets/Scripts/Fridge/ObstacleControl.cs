using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
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
        string seconds = DateTime.Now.TimeOfDay.Seconds.ToString();
        string milliseconds = DateTime.Now.TimeOfDay.Milliseconds.ToString();

        string timeComb = (seconds + milliseconds);

        string fourNums = timeComb.Substring(0, 4);
        string newCode = "";

        for (int i = 0; i < 4; i++)
        {
            switch (fourNums[i])
            {
                case '0':
                    newCode += '0';
                    break;
                case '1':
                    newCode += '1';
                    break;
                case '2':
                    newCode += '2';
                    break;
                case '3':
                    newCode += '0';
                    break;
                case '4':
                    newCode += '1';
                    break;
                case '5':
                    newCode += '2';
                    break;
                case '6':
                    newCode += '0';
                    break;
                case '7':
                    newCode += '1';
                    break;
                case '8':
                    newCode += '2';
                    break;
                case '9':
                    newCode += '0';
                    break;

            }
        }

        Debug.Log(newCode);

        SafeLane1 = newCode[0];
        SafeLane1 -= 48;
        SafeLane2 = newCode[1];
        SafeLane2 -= 48;
        SafeLane3 = newCode[2];
        SafeLane3 -= 48;
        SafeLane4 = newCode[3];
        SafeLane4 -= 48;

        Debug.Log(SafeLane1);
        Debug.Log(SafeLane2);
        Debug.Log(SafeLane3);
        Debug.Log(SafeLane4);

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
