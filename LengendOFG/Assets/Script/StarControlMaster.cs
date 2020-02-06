using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarControlMaster : MonoBehaviour
{
    private GameObject eventSystem;
    private MouseController mousepos;
    private Canvas starUIcanvas;
    private StarUIControlMaster starUIscript;

    public string myStarName;
    // Start is called before the first frame update

    private void Awake()
    {
        myStarName = gameObject.name;
        eventSystem = GameObject.Find("EventSystem");
        mousepos = eventSystem.GetComponent<MouseController>();
        starUIcanvas = GameObject.Find("StarUICanvas").GetComponent<Canvas>();
        starUIscript = GameObject.Find("StarUICanvas").GetComponent<StarUIControlMaster>();
    }
    void Start()
    {
        starUIscript.starSystemUICanvas.gameObject.SetActive(false);
        starUIcanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StarIsClick();
            if (mousepos.ClickObject() == transform.gameObject)
            {
                StarUIShow();
                starUIscript.starControlMaster = this;
            }
            if (mousepos.ClickObject() == GameObject.Find("Main Camera"))
            {
                starUIcanvas.gameObject.SetActive(false);
            }
        }
        

    }


    public bool StarIsClick()
    {
        float starRadius = 0.32f;
        float starxpos = gameObject.transform.position.x;
        float starypos = gameObject.transform.position.y;

        if (mousepos.mouseClickPosition.x <= starxpos + starRadius && mousepos.mouseClickPosition.y <= starypos+starRadius)
        {
            if (mousepos.mouseClickPosition.x >= starxpos - starRadius && mousepos.mouseClickPosition.y >= starypos - starRadius)
            {
                Debug.Log("starClick!");
                return true;
            }
        }
        return false;
    }

    public void StarUIShow()
    {
        Vector3 mystarPosition = new Vector3(gameObject.transform.position.x + 1.9f, gameObject.transform.position.y - 1.18f, gameObject.transform.position.z);
        if (starUIcanvas.transform.position == mystarPosition)
        {
            if (starUIcanvas.gameObject.activeSelf)
            {
                starUIcanvas.gameObject.SetActive(false);
            }
            else
            {
                starUIcanvas.gameObject.SetActive(true);
            }
        }
        else
        {
            starUIcanvas.transform.position = mystarPosition;
            starUIcanvas.gameObject.SetActive(true);
        }
    }
}
