using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThumbsWinScript : MonoBehaviour
{
    public float FloatSpeed;
    public float Offset;
    private float OriginYVal;
    private bool IsWin;
    // Start is called before the first frame update
    void Start()
    {
        OriginYVal = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(transform.position.x, 
            OriginYVal + (float)Mathf.Sin(Time.time * FloatSpeed) * Offset,
            transform.position.z);
    }
    public void SetWin(bool Winstate)
    {
        IsWin = Winstate;
        ToggleThumbImage();
    }

    private void ToggleThumbImage()
    {
        if (IsWin)
        {
            gameObject.GetComponent<Image>().color = Color.green;
        }
        else
        {
            gameObject.GetComponent<Image>().color= Color.red;
        }
    }
}
