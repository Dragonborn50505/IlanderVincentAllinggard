using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float currentTime = 0f;
    private float startingTime = 10f;
    private bool GameIsGoing = false;
    private string sceneName;
    
    [SerializeField] GameObject PauseMenuUi;
    [SerializeField] GameObject LostOrWinMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        GameIsGoing = true;
        currentTime = startingTime;
        Scene currentScene = SceneManager.GetActiveScene ();
        sceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {
        if ((currentTime > 0) && GameIsGoing)
        {
            currentTime -= 1 * Time.deltaTime;
            //Debug.Log(currentTime);   
        }
        if ((currentTime <= 0) && GameIsGoing)
        {
            Time.timeScale = 0f;
            currentTime = 0;
            GameIsGoing = false;
            Debug.Log("loadGameEndedScreen");
            PauseMenuUi.SetActive(false);
            LostOrWinMenu.SetActive(true);
        }
    }
    public void NextLevel()
    {
        Time.timeScale = 1f;
        if (sceneName == "Level1")
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("Level2"); 
        }
        else if (sceneName == "Level2")
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("Level3"); 
        }
        else if (sceneName == "Level3")
        {
            Time.timeScale = 1;
            Debug.Log("No New Level");
        }
    }
    public void LeaveToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    
}
