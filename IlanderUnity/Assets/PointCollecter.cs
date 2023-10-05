using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PointCollecter : MonoBehaviour
{
    private int point = 0;
    public Transform obj;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [SerializeField] private TextMeshProUGUI playerOneScore;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("test");
        if (collision.gameObject.CompareTag("Players"))
        {
            //obj.transform.position = ObjektMovement.spaceObjektPosition;
            point++;
            playerOneScore.text = "Player 1: " + point;
            Debug.Log("Player: " + point);
        }
    }
}





















//[SerializeField] public TMPro.TextMeshProUGUI PlayerOneScore;
//public TMP_Text PlayerOneScore;
//public TextMeshProUGUI PlayerOneScore;
//ObjektMovement.obj.transform.position = ObjektMovement.SpaceObjekt;h