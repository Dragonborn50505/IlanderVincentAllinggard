using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed = 4f;
    public bool isPlayer1;
    public Transform obj;
    Vector2 movement;
    

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
        }

        if (movement.y > 0)
        {
            Debug.Log("Gravity Off"); 
            Physics.gravity = new Vector3(0,0);
           //forceDirection = forceDirection * -1;
           //this.rigidbody2D.gravityScale = 0.0f;
        }
        Vector3 tempVect = new Vector3(movement.x,movement.y);
        tempVect = tempVect.normalized * moveSpeed * Time.deltaTime;

        obj.transform.position += tempVect;
    }
}
