using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowController : MonoBehaviour
{

    public GameObject window;
    public GameObject previousWindow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
