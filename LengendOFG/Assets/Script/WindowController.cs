using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowController : MonoBehaviour
{

    public GameObject window;
    public GameObject previousWindow;

    public void WinodwShow(GameObject setwinodw)
    {
        window = setwinodw;
        if (!window.activeSelf)
            window.SetActive(true);
        else
            window.SetActive(false);
        if (previousWindow!=window)
            previousWindow.SetActive(false);
        previousWindow = window;
    }
}
