using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{

    private void Update()
    {
        transform.position += new Vector3(0, 0, (float)-0.1);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Dangerzone"))
        {
            Destroy(gameObject);
        }
    }

}
