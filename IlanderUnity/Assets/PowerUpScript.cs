using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    private float CurrentPowerUpTime = 0f;
    private float PowerUpTime = 5f;
    
    public float PowerUpCooldown = 20f;
    public bool PowerUpActivated = false;
    public bool restartPowerUp = false;
    public Transform objPowerUp;

    
    // Start is called before the first frame update
    void Start()
    {
        CurrentPowerUpTime = PowerUpTime;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 powerUpRestart = new Vector3(x: 12, y: Random.Range(-3, 3), z: -1);
        Vector3 goAway = new Vector3(x: -12, 0, z: 0);
        if ((PowerUpCooldown == 20f) && restartPowerUp)
        {
            objPowerUp.position = powerUpRestart;
            restartPowerUp = false;
        }
        else if ((objPowerUp.position.x < -12) && (PowerUpCooldown == 20f) && restartPowerUp == false)
        {
            objPowerUp.position = powerUpRestart;
        }
        if(PowerUpActivated)
        { 
            if (CurrentPowerUpTime > 0)
            {
                Time.timeScale = 0.5f;
                CurrentPowerUpTime -= 1 * Time.deltaTime;
                objPowerUp.position = goAway;

            }

            if ((CurrentPowerUpTime <= 0))
            {
                Time.timeScale = 1;
                PowerUpCooldown -= 1 * Time.deltaTime;
            }

            if (PowerUpCooldown <= 0)
            {
                PowerUpCooldown = 20;
                CurrentPowerUpTime = PowerUpTime;
                PowerUpActivated = false;
                restartPowerUp = true;

            }
        }
    }
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Players"))
        {
            PowerUpActivated = true;
        }
    }
    
}
