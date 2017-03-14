using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenu : MonoBehaviour {

    public GameObject startScreen, main;

    //checks to see if the "escape" or 'p' keys have been pressed
    //if they have then togglePauseMenu() is called
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            toggleMainMenu();
        }
    }

    //if the game is visible then its set to not visble 
    //and the pause menu is shown and vice versa
    public void toggleMainMenu()
    {

        if (main.activeSelf == true)
        {
            startScreen.SetActive(true);
            main.SetActive(false);
        }
        else
        {
            startScreen.SetActive(false);
            main.SetActive(true);
        }

    }

}
