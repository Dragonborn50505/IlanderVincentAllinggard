using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCollecter : MonoBehaviour
{
    private int point = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //[SerializeField] private TextMeshProUGUI PlayerOneScore;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Players"))
        {
                                                                    //ObjektMovement.obj.transform.position = ObjektMovement.SpaceObjekt;
            point++;
            //PlayerOneScore.text = "Player 1: " + point;
            Debug.Log("coins: " + point);
        }
    }
}
