using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipControlMaster : MonoBehaviour
{
    public Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        GetMainCamera();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetMainCamera()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        gameObject.transform.Find("SpaceShipCanvas").gameObject.GetComponent<Canvas>().worldCamera = mainCamera;
        return;
    }
}
