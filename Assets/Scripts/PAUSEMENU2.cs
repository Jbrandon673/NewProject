using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PAUSEMENU2 : MonoBehaviour
{
    public GameObject pauseUI;
    bool isPaused = false;

    private void Update()
    {
        if (Input.GetButton("Cancel"))
        {
            PauseGame();
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                PauseGame();
            }
        }
    }







    public void PauseGame()
    {
        if (isPaused == true)
        {
            //unpause
            Time.timeScale = 1f;


            //Hides the button when the game is unpaused.
            pauseUI.SetActive(false);
            //Don't stop animation

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

    public void ResumeGame()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        //Don't stop animation
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("ENDRUNGAMEMENU");
    }
    public void QuitGame()
    {
        Application.Quit();

    }
}
