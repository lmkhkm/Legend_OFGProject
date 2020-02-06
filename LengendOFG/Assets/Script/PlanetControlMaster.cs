using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetControlMaster : MonoBehaviour
{
    private GameObject eventSystem;
    private MouseController mousepos;
    private Canvas planetUIcanvas;

    public string myPlanetName;
    // Start is called before the first frame update
    void Start()
    {
        myPlanetName = gameObject.name;
        eventSystem = GameObject.Find("EventSystem");
        mousepos = eventSystem.GetComponent<MouseController>();
        planetUIcanvas = GameObject.Find("PlanetUICanvas").GetComponent<Canvas>();
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
        if (planetUIcanvas.transform.position == myplanetPosition)
        {
            if (planetUIcanvas.gameObject.activeSelf)
            {
                planetUIcanvas.gameObject.SetActive(false);
            }
            else
            {
                planetUIcanvas.gameObject.SetActive(true);
            }
        }
        else
        {
            planetUIcanvas.transform.position = myplanetPosition;
            planetUIcanvas.gameObject.SetActive(true);
        }
    }
}
