using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PointCollecter : MonoBehaviour
{
    private int playerOnePoint = 0;
    private int playerTwoPoint = 0;
    public Transform obj;
    private PlayerMovement pM;
    public GameObject p1;
    public GameObject p2;

    // Start is called before the first frame update
    void Start()
    {
        pM = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    [SerializeField] private TextMeshProUGUI playerOneScore;
    [SerializeField] private TextMeshProUGUI playerTwoScore;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Players"))
        {   
            if (p1){
                Debug.Log("Player1");
                Vector3 spaceObjektPosition = new Vector3(x: 20, y: Random.Range(-3, 3), z: -1);
                obj.transform.position = spaceObjektPosition;
                playerOnePoint++;
                playerOneScore.text = "Player 1: " + playerOnePoint;
            }
            else if (p2)
            {
                Debug.Log("Player2");
                Vector3 spaceObjektPosition = new Vector3(x: 20, y: Random.Range(-3, 3), z: -1);
                obj.transform.position = spaceObjektPosition;
                playerTwoPoint++;
                playerTwoScore.text = "Player 2: " + playerTwoPoint;
            }
        }
    }
}





















//[SerializeField] public TMPro.TextMeshProUGUI PlayerOneScore;
//public TMP_Text PlayerOneScore;
//public TextMeshProUGUI PlayerOneScore;
//ObjektMovement.obj.transform.position = ObjektMovement.SpaceObjekt;h