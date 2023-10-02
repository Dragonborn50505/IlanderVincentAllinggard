using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektMovement : MonoBehaviour
{
    public Transform obj;
    Vector2 movement;
    public bool isRoofObjekt;
    public bool isGroundOnjekt;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = 5;
        Vector3 tempVect = new Vector3(movement.x,0);
        tempVect = tempVect.normalized * movement * Time.deltaTime;
        
        Vector3 RoofStartingPosition = new Vector3(x: 12 + Random.Range(0, 20), y: 3, z: -1);
        Vector3 GroundStartingPosition = new Vector3(x: 12 + Random.Range(0, 20), y: -3, -1);
        Vector3 SpaceObjekt = new Vector3(x: 12, y: Random.Range(-3, 3), z: -1);
        //static extern local function (Vector3 SpaceObjekt = new Vector3(x: 12, y: Random.Range(-3, 3), z: -1));
        //RoofStartingPosition = RoofStartingPosition.normalized * movement * Time.deltaTime;
        
        if (isRoofObjekt && obj.position.x < -12)
        { 
            obj.transform.position = RoofStartingPosition;
        }
        if (isGroundOnjekt && obj.position.x < -12)
        {
            obj.transform.position = GroundStartingPosition;
        }
        if (!isRoofObjekt && !isGroundOnjekt && obj.position.x < -12)
        {
            obj.transform.position = SpaceObjekt;
        }
        else
        {
            obj.transform.position -= tempVect;
        }


        
    }
}
