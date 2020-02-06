using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarUIControlMaster : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera camera;
    public StarControlMaster starControlMaster;
    public Canvas mainUICanvas;
    public Canvas starSystemUICanvas;
    
    private WindowController windowController;

    private void Awake()
    {
        windowController = GameObject.Find("EventSystem").GetComponent<WindowController>();
    }

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ViewStarSystem()
    {
        camera.transform.position = new Vector3(0f, -10f, -10f);
        starSystemUICanvas.gameObject.SetActive(true);
        windowController.isStarSystem = true;
        Debug.Log("View Star System");
    }

    public void ExitStarSystem()
    {
        camera.transform.position = new Vector3(0f, 0f, -10f);
        starSystemUICanvas.gameObject.SetActive(false);
        windowController.isStarSystem = false;
        Debug.Log("Exit Star System");
    }
}
