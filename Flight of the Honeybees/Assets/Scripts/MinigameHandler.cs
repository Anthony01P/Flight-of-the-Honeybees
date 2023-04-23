using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinigameHandler : MonoBehaviour
{
    //Objective Variable
    public int flowers;
    public GameObject[] flowerBeds;
    public GameObject[] arrow;

    public GameObject noFlower;
    public GameObject oneFlower;
    public GameObject twoFlower;
    public GameObject threeFlower;
    public GameObject fourFlower;

    // Start is called before the first frame update
    void Start()
    {
        //Assignment of Canvas Renderer to tRenderer
        //tRenderer = collected.GetComponent<CanvasRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Checks for the current objective count and updates image according to value
        CheckFlowerCount();
        if (flowers >= 4)
        {
            foreach (GameObject i in flowerBeds)
            {
                i.tag = "Collected";
            }
            foreach (GameObject i in arrow)
            {
                i.SetActive(false);
            }
        }
    }
    public void CheckFlowerCount()
    {
        if(GameObject.FindGameObjectsWithTag("Collected").Length == 1)
        {
            flowers = 1;
            noFlower.SetActive(false);
            oneFlower.SetActive(true);
            twoFlower.SetActive(false);
            threeFlower.SetActive(false);
            fourFlower.SetActive(false);
        }
        else if (GameObject.FindGameObjectsWithTag("Collected").Length == 2)
        {
            flowers = 2;
            noFlower.SetActive(false);
            oneFlower.SetActive(false);
            twoFlower.SetActive(true);
            threeFlower.SetActive(false);
            fourFlower.SetActive(false);
        }
        else if (GameObject.FindGameObjectsWithTag("Collected").Length == 3)
        {
            flowers = 3;
            noFlower.SetActive(false);
            oneFlower.SetActive(false);
            twoFlower.SetActive(false);
            threeFlower.SetActive(true);
            fourFlower.SetActive(false);
        }
        else if (GameObject.FindGameObjectsWithTag("Collected").Length >= 4)
        {
            flowers = 4;
            noFlower.SetActive(false);
            oneFlower.SetActive(false);
            twoFlower.SetActive(false);
            threeFlower.SetActive(false);
            fourFlower.SetActive(true);
        }
    }
}
