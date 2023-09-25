using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektMovement : MonoBehaviour
{
    public Transform obj;
    Vector2 movement;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = 5;
        Vector3 tempVect = new Vector3(movement.x,movement.y);
        tempVect = tempVect.normalized * movement * Time.deltaTime;
        obj.transform.position -= tempVect;
    }
}
