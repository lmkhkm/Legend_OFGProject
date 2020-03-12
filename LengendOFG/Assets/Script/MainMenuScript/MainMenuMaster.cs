using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMaster : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mainMenu;
    public GameObject newGame;
    public GameObject loadGame;
    public GameObject setting;
    

    public void ChangeMainMenuWindow(GameObject mainMenuWindow)
    {
        mainMenuWindow.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void GoMainMenuWindow(GameObject mainMenuWindow)
    {
        mainMenuWindow.SetActive(false);
        mainMenu.SetActive(true);
    }

}
