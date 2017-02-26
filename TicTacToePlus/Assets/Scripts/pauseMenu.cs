using UnityEngine;

public class pauseMenu : MonoBehaviour {

    public GameObject ui, game;

    //checks to see if the "escape" or 'p' keys have been pressed
    //if they have then togglePauseMenu() is called
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P)) {
            togglePauseMenu();
        }
	}

    //if the game is visible then its set to not visble 
    //and the pause menu is shown and vice versa
    public void togglePauseMenu() {

        if (game.activeSelf == true)
        {
            ui.SetActive(true);
            game.SetActive(false);
        }
        else
        {
            ui.SetActive(false);
            game.SetActive(true);
        }
 
    }

}
