﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetControlMaster : MonoBehaviour
{
    private GameObject eventSystem;
    private MouseController mousepos;
    private Canvas planetUIcanvas;
    private Camera mainCamera;

    public string myPlanetName;
    // Start is called before the first frame update

    private void Awake()
    {
        myPlanetName = gameObject.name;
        eventSystem = GameObject.Find("EventSystem");
        mousepos = eventSystem.GetComponent<MouseController>();
        planetUIcanvas = GameObject.Find("PlanetUICanvas").GetComponent<Canvas>();
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    void Start()
    {
        planetUIcanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlanetIsClick();
            if (mousepos.ClickObject() == transform.gameObject)
            {
                PlanetUIShow();
            }
            if (mousepos.ClickObject() == GameObject.Find("Main Camera"))
            {
                planetUIcanvas.gameObject.SetActive(false);
            }
        }


    }


    public bool PlanetIsClick()
    {
        float starRadius = 0.32f;
        float starxpos = gameObject.transform.position.x;
        float starypos = gameObject.transform.position.y;

        if (mousepos.mouseClickPosition.x <= starxpos + starRadius && mousepos.mouseClickPosition.y <= starypos + starRadius)
        {
            if (mousepos.mouseClickPosition.x >= starxpos - starRadius && mousepos.mouseClickPosition.y >= starypos - starRadius)
            {
                Debug.Log("Planet Click!");
                return true;
            }
        }
        return false;
    }

    public void PlanetUIShow()
    {
        Vector3 myplanetPosition = new Vector3(gameObject.transform.position.x + 1.9f, gameObject.transform.position.y - 1.18f, gameObject.transform.position.z);

        if (planetUIcanvas.gameObject.activeSelf)
        {
            planetUIcanvas.gameObject.SetActive(false);
        }
        else
        {
            planetUIcanvas.gameObject.transform.position = new Vector3( mainCamera.gameObject.transform.position.x, mainCamera.gameObject.transform.position.y,0);
            planetUIcanvas.gameObject.SetActive(true);
        }
    }
}
