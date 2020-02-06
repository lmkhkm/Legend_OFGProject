using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{

    public Camera camera;

    public Vector3 mousePosition = new Vector3();
    public Vector3 mouseClickPosition = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = camera.ScreenToWorldPoint(mousePosition);
        
        if (Input.GetMouseButtonDown(0))
        {
            mouseClickPosition = Input.mousePosition;
            mouseClickPosition = camera.ScreenToWorldPoint(mouseClickPosition);
            Debug.Log(mouseClickPosition);
            Debug.Log(mousePosition);
            Debug.Log(ClickObject().name);
        }
    }

    public GameObject ClickObject()
    {
        RaycastHit2D hit = Physics2D.Raycast(mousePosition, transform.forward, 100f);
        if (hit)
        {
            return hit.transform.gameObject;
        }
        return camera.transform.gameObject;
    }
}
