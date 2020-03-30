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
    public GameObject backButton;
    

    public void ChangeMainMenuWindow(GameObject mainMenuWindow)
    {
        mainMenuWindow.SetActive(true);
        backButton.SetActive(true);

        mainMenu.SetActive(false);
    }

    public void GoMainMenuWindow()
    {
        newGame.SetActive(false);
        loadGame.SetActive(false);
        setting.SetActive(false);
        backButton.SetActive(false);

        mainMenu.SetActive(true);
    }

}
