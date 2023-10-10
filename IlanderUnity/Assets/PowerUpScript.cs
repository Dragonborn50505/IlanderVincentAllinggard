using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    private float CurrentPowerUpTime = 0f;
    private float PowerUpTime = 5f;
    
    public float PowerUpCooldown = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 powerUpRestart = new Vector3(x: 12, y: Random.Range(-3, 3), z: -1);
        if (PowerUpCooldown == 0)
        {
            gameObject.transform.position = powerUpRestart;
        }
    }
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Players"))
        {
            CurrentPowerUpTime = PowerUpTime;
            if ((CurrentPowerUpTime > 0))
            {
                CurrentPowerUpTime -= 1 * Time.deltaTime;
                Time.timeScale = 0.5f;
            }

            if ((CurrentPowerUpTime <= 0) && PowerUpCooldown < 0)
            {
                Time.timeScale = 1f;
                PowerUpCooldown -= 1 * Time.deltaTime;
            }

            if (PowerUpCooldown <= 0)
            {
                PowerUpCooldown = 20;
            }
        }
    }
    
}
