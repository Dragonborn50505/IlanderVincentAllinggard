using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed = 4f;
    public bool isPlayer1;
    public Transform obj;
    Vector2 movement;
    public static Rigidbody2D rb;
    //public static Rigidbody rsb;

    

    //private ConstantForce2D cForce;
    //private Vector3 forceDirection;
    
    // Start is called before the first frame update
    void Start()
    {
        //cForce = GetComponent<ConstantForce2D>();
        //forceDirection = new Vector3(0, -5);
        //cForce.force = forceDirection;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            movement.x = Input.GetAxisRaw("Horizontal1");
            movement.y = Input.GetAxisRaw("Vertical1");
        }
        else
        {
            movement.x = Input.GetAxisRaw("Horizontal2");
            movement.y = Input.GetAxisRaw("Vertical2");
            //if(Input.GetKeyDown(KeyCode.T))
            //{
            //    forceDirection = forceDirection * -1; 
            //}
        }
        
        Vector3 tempVect = new Vector3(movement.x,movement.y);
        tempVect = tempVect.normalized * moveSpeed * Time.deltaTime;

        if (movement.y != 0) //!isPlayer1 && (movement.y != 0)            (isPlayer1) && (movement.y > moveSpeed)
        { 
            //Debug.Log("Gravity Off");
            //rsb.useGravity = false;
            //rb.useGravity = false;
            //rb.gravityScale = 0.0f;
            //Physics.gravity = new Vector3(0,0);
            Physics2D.gravity = Vector3.zero;
                                                        //Debug.Log("Gravity Off 2");
            ////forceDirection = forceDirection * -1;
            //this.rigidbody2D.gravityScale = 0.0f;
        }
        
        obj.transform.position += tempVect;
        
        
       
    }
    public void OnTriggerEnter2D(Collider2D collison)
    {
        Debug.Log("Player hit");
        if (collison.gameObject.tag == "Player")
        {
            
        }
        else
        {
            Debug.Log("Hit");
        }
    }

}
