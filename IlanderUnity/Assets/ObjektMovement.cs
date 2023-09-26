using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektMovement : MonoBehaviour
{
    public Transform obj;
    Vector2 movement;
    public bool isRoofObjekt;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = 5;
        Vector3 tempVect = new Vector3(movement.x,0);
        Vector3 RoofStartingPosition = new Vector3(x: 12 + Random.Range(0, 10), y: 3, -1);
        Vector3 GroundStartingPosition = new Vector3(x: 12 + Random.Range(0, 10), y: -3, -1);
        tempVect = tempVect.normalized * movement * Time.deltaTime;
        if (isRoofObjekt && obj.position.x < -12)
        { 
            obj.transform.position = RoofStartingPosition;
        }
        if (!isRoofObjekt && obj.position.x < -12)
        {
            obj.transform.position = GroundStartingPosition;
        }
        else
        {
            obj.transform.position -= tempVect;
        }


        
    }
}
