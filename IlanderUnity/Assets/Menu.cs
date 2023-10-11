using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public bool Campaign = false;
    
    [SerializeField] GameObject MainMenuUi;
    [SerializeField] GameObject CampaignUi;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LoadCampaign()
    {
        Campaign = true;
        SceneManager.LoadScene("Level1");
    }

    private void LevelSelect()
    {
        MainMenuUi.SetActive(false);
        CampaignUi.SetActive(true);
    }

    private void Level1()
    {
        MainMenuUi.SetActive(true);
        CampaignUi.SetActive(false);
        SceneManager.LoadScene("Level1");
    }
    
    private void Level2()
    {
        MainMenuUi.SetActive(true);
        CampaignUi.SetActive(false);
        SceneManager.LoadScene("Level2");
    }
    
    private void Level3()
    {
        MainMenuUi.SetActive(true);
        CampaignUi.SetActive(false);
        SceneManager.LoadScene("Level3");
    }
    
}
