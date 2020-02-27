using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceMover : MonoBehaviour
{
    public Image background;
    public RectTransform rect_background;
    Vector2 MousePos;
    readonly int mouseslowdown = 60;


    private void Start()
    {
        rect_background = GetComponent<RectTransform>();
    }
    // Update is called once per frame

    void Update()
    {
        
        MousePos.x = Input.mousePosition.x/ mouseslowdown;
        MousePos.y = Input.mousePosition.y/ mouseslowdown;
        rect_background.anchoredPosition = MousePos;
        //Debug.Log(MousePos);

    }
}
