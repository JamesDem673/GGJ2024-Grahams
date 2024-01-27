using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StringBehaviour : MonoBehaviour
{
    public GameObject post;
    public GameObject head;

    private void Update()
    {
        Vector3 pos1 = post.transform.position;
        Vector3 pos2 = head.transform.position;
        Vector3 difference = pos1 - pos2;
        float scale = (difference).magnitude;
        Vector3 a = transform.localScale;
        a.y = scale;
        transform.localScale = a;
        transform.position = pos2 + (0.5f * difference);

        float b = Mathf.Atan2(pos1.x-pos2.x, pos1.y-pos2.y);

        transform.rotation = Quaternion.Euler(0, 0, -(b * (180/Mathf.PI)));
    }
}
