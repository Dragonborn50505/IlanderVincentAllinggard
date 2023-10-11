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
    private void Update()
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

    private void Resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        PauseMenuUi.SetActive(false);
        Ui.SetActive(true);
    }

    private void Pause()
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
