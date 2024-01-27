using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Losing : MonoBehaviour
{
    public GameObject loss;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
            SuspenseLoss();
    }

    public void SuspenseLoss()
    {
        loss.SetActive(true);
    }
}
