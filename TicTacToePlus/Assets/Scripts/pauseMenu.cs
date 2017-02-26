using UnityEngine;

public class pauseMenu : MonoBehaviour {

    public GameObject ui, game;

	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P)) {
            togglePauseMenu();
        }
	}

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
        

        if (ui.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

}
