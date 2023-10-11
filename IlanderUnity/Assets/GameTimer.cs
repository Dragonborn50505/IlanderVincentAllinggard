using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    private float currentTime;
    private float startingTime = 30f; //Time intended to be 120f but shorten it for your convenience.
    private bool GameIsGoing;
    public static string sceneName;
    
    [SerializeField] GameObject PauseMenuUi;
    [SerializeField] GameObject LostOrWinMenu;
    [SerializeField] GameObject Ui;

    
    // Start is called before the first frame update
    public void Start()
    {
        GameIsGoing = true;
        currentTime = startingTime;
        Scene currentScene = SceneManager.GetActiveScene (); //get active scene so you can use it. 
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
            Ui.SetActive(false);
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
