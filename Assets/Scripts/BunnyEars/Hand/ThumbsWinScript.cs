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
    public Sprite thumbsUp;
    public Sprite ThumbsDown;
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
        gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        if (IsWin)
        {
            gameObject.GetComponent<Image>().sprite = thumbsUp;
        }
        else
        {
            gameObject.GetComponent<Image>().sprite = ThumbsDown;
        }
    }
}
