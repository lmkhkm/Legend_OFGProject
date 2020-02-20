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

    public string currentStarName;
    public short currentStarNumber;
    
    private WindowController windowController;
    private short maxPlanetNumber = 200;


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
        for (int i=1;i< maxPlanetNumber+1; i++)
        {
            if (i == currentStarNumber)
            {
                camera.transform.position = new Vector3(0f, 10f * (-1f) * i,-10f);
                break;
            }
        }
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
