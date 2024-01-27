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

    float SafeLane1 = 0;
    float SafeLane2 = 0;
    float SafeLane3 = 0;
    float SafeLane4 = 0;

    int block_count = 0;

    void Start()
    {
        Random.InitState(42);
        int randomNum = Random.Range(0, 2);

        section1.transform.GetChild(randomNum).gameObject.SetActive(false);
        SafeLane1 = section1.transform.GetChild(randomNum).transform.position.x;

        randomNum = Random.Range(0, 2);
        section2.transform.GetChild(randomNum).gameObject.SetActive(false);
        SafeLane2 = section2.transform.GetChild(randomNum).transform.position.x;

        randomNum = Random.Range(0, 2);
        section3.transform.GetChild(randomNum).gameObject.SetActive(false);
        SafeLane3 = section3.transform.GetChild(randomNum).transform.position.x;

        randomNum = Random.Range(0, 2);
        section4.transform.GetChild(randomNum).gameObject.SetActive(false);
        SafeLane4 = section4.transform.GetChild(randomNum).transform.position.x;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Fridge"))
        {
            switch (block_count)
            {
                case 0:
                    fridge.transform.position = new Vector3(SafeLane1, fridge.transform.position.y, fridge.transform.position.z);
                    break;
                case 1:
                    fridge.transform.position = new Vector3(SafeLane2, fridge.transform.position.y, fridge.transform.position.z);
                    break;
                case 2:
                    fridge.transform.position = new Vector3(SafeLane3, fridge.transform.position.y, fridge.transform.position.z);
                    break;
                case 3:
                    fridge.transform.position = new Vector3(SafeLane4, fridge.transform.position.y, fridge.transform.position.z);
                    break;
            }
        }
    }

    void SwitchLane(float safelaneActive)
    {

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
