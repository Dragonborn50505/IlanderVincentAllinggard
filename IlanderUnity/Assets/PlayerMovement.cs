using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    
    public float moveSpeed = 4f;
    public bool isPlayer1;
    public bool isPlayer2;
    public Transform obj;
    //public Transform obj2;
    Vector2 movement;
    public static Rigidbody2D rb;
    public bool gravity = true;

    // Start is called before the first frame update
    void Start()
    {
        
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
        
        Vector3 tempVect = new Vector3(movement.x,movement.y);
        tempVect = tempVect.normalized * moveSpeed * Time.deltaTime;
        
        if (isPlayer1 && movement.y != 0)
        {
            obj.GetComponent<Rigidbody2D> ().gravityScale = 0;
        }
        else if (isPlayer1 && movement.y == 0)
        {
            obj.GetComponent<Rigidbody2D> ().gravityScale = 1;
        }
        
        obj.transform.position += tempVect;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Meet");
        }
    }

    public void OnCollisionenter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Damage");
        }
    }
 
}