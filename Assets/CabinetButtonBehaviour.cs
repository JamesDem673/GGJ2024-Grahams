using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public enum boogle
{
    Up = 1, Right = 2, Down = 3, Left = 4
};
public class CabinetButtonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 startingPos;
    void Start()
    {
        startingPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 Pos = gameObject.transform.position;
            Pos.y = gameObject.transform.position.y - 0.29f;
            gameObject.transform.position = Pos;
            Debug.Log("CLICK WAHAA");
        }
        else if (Input.GetMouseButtonUp(0))
        {
            gameObject.transform.position = startingPos;
        }

    }
}
