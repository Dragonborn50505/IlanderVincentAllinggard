using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public bool GameIsPaused = false;

    [SerializeField] GameObject PauseMenuUi;
    [SerializeField] GameObject Ui;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        PauseMenuUi.SetActive(false);
        Ui.SetActive(true);
    }

    void Pause()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
        PauseMenuUi.SetActive(true);
        Ui.SetActive(false);
    }

    public void LeaveToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    
}
