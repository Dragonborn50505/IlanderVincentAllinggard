using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektMovement : MonoBehaviour
{
    public Transform obj;
    Vector2 movement;
    public bool isRoofObjekt;
    public bool isGroundOnjekt;
    public bool isPowerUp;
    public RandomOrder test;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        movement.x = 5;
        Vector3 tempVect = new Vector3(movement.x,0);
        tempVect = tempVect.normalized * movement * Time.deltaTime;
        
        Vector3 roofStartingPosition = new Vector3(x: 12 + Random.Range(0, 20), y: 3, z: -1);
        Vector3 groundStartingPosition = new Vector3(x: 12 + Random.Range(0, 20), y: -3, -1);
        Vector3 spaceObjektPosition = new Vector3(x: 12, y: Random.Range(-3, 3), z: -1);
        
        if (isRoofObjekt && obj.position.x < -12)
        { 
            obj.transform.position = roofStartingPosition;
            if (GameTimer.sceneName == ("Level3"))
            {
                
                test.RandomGo();
            }
        }
        if (isGroundOnjekt && obj.position.x < -12)
        {
            obj.transform.position = groundStartingPosition;
        }
        if (!isRoofObjekt && !isGroundOnjekt && !isPowerUp && obj.position.x < -12)
        {
            obj.transform.position = spaceObjektPosition;
        }
        else
        {
            obj.transform.position -= tempVect;
        }
        
    }
    
}
