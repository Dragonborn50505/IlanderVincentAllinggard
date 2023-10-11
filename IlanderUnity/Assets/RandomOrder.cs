using UnityEngine;

public class RandomOrder : MonoBehaviour
{
    
    public GameObject roofObj;
    public GameObject tallRoofObj;
    public GameObject shortRoofObj;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomGo()
    {
        int generateRandomBlock = Random.Range(0, 3);
        if (gameObject.name == ("BlockRoof"))
        {
            roofObj.SetActive(false);
            if (generateRandomBlock == 0)
            {
                roofObj.SetActive(true);
            }
            else if (generateRandomBlock == 1)
            {
                tallRoofObj.SetActive(true);
            }
            else if (generateRandomBlock == 2)
            {
                shortRoofObj.SetActive(true);
            }
        }
        else if (gameObject.name == ("TallBlockRoof"))
        {
            tallRoofObj.SetActive(false);
            if (generateRandomBlock == 0)
            {
                roofObj.SetActive(true);
            }
            else if (generateRandomBlock == 1)
            {
                tallRoofObj.SetActive(true);
            }
            else if (generateRandomBlock == 2)
            {
                shortRoofObj.SetActive(true);
            }
        }
        else if (gameObject.name == ("ShortBlockRoof"))
        {
            shortRoofObj.SetActive(false);
            if (generateRandomBlock == 0)
            {
                roofObj.SetActive(true);
            }
            else if (generateRandomBlock == 1)
            {
                tallRoofObj.SetActive(true);
            }
            else if (generateRandomBlock == 2)
            {
                shortRoofObj.SetActive(true);
            }
        }
    }
}
