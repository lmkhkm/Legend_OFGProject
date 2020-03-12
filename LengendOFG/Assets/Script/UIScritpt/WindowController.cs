using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class WindowController : MonoBehaviour
{
    public GameObject nullWindow;
    public GameObject window;
    public GameObject previousWindow;
    public bool isStarSystem;
    public MouseController mouseController;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject() == false)//UI를 클릭했을 때는 발동하지 않도록함
            {
                
                WinodwShow(nullWindow);
            }

        }
    }

    public void WinodwShow(GameObject setwindow)
    {
        if (mouseController.ClickObject() == mouseController.camera)
        {
            previousWindow.gameObject.SetActive(false);
            previousWindow = setwindow;
            return;
        }
        window = setwindow;
        if (!window.activeSelf)
            window.SetActive(true);
        else
            window.SetActive(false);
        if (previousWindow!=window)
            previousWindow.SetActive(false);
        previousWindow = window;
    }
}
