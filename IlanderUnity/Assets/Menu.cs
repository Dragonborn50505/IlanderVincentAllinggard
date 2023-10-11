using System.Collections;
using System.Collections.Generic;
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
    public void LoadCampaign()
    {
        Campaign = true;
        SceneManager.LoadScene("Level1");
    }

    public void LevelSelect()
    {
        MainMenuUi.SetActive(false);
        CampaignUi.SetActive(true);
    }

    public void Level1()
    {
        MainMenuUi.SetActive(true);
        CampaignUi.SetActive(false);
        SceneManager.LoadScene("Level1");
    }
    
    public void Level2()
    {
        MainMenuUi.SetActive(true);
        CampaignUi.SetActive(false);
        SceneManager.LoadScene("Level2");
    }
    
    public void Level3()
    {
        MainMenuUi.SetActive(true);
        CampaignUi.SetActive(false);
        SceneManager.LoadScene("Level3");
    }
    
}
