using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseUI;
    bool isPaused = false;

    private void Update()
    {
        if (Input.GetButton("Cancel"))
        {
            TogglePause();
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {

            }
        }
    }







    public void TogglePause()
    {
        if (isPaused == true)
        {
            //unpause
            Time.timeScale = 1.0f;


            //Hides the button when the game is unpaused.
            pauseUI.SetActive(false);

        }
        else
        {
            //pause
            Time.timeScale = 1;


            //Shows the button when the game is paused
            pauseUI.SetActive(true);

            
            //When ispaused is false, this line will set to true
        }

        isPaused = !isPaused;
    }
    public void Quit()
    {
        Application.Quit();

    }
}
    


    
