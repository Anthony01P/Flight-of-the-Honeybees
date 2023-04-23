using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameHandler : MonoBehaviour
{
    //Image GameObject
    public GameObject collectedImage;
    //Page 1 of Journal Object
    public GameObject page1;
    //Page 2 of Journal Object
    public GameObject page2;
    //Page 3 of Journal Object
    public GameObject page3;
    //Page 4 of Journal Object
    public GameObject page4;
    //Collection of images for the "collected" object
    public Texture[] images;
    //Renderer of "collected" object
    public CanvasRenderer tRenderer;
    //Objective Variable
    public int pollen;

    // Start is called before the first frame update
    void Start()
    {
        //Assignment of Canvas Renderer to tRenderer
        tRenderer = collectedImage.GetComponent<CanvasRenderer>();
        //page1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //Checks for the current objective count and updates image according to value
        switch (pollen)
        {
            case 1: tRenderer.SetTexture(images[0]); break;
            case 2: tRenderer.SetTexture(images[1]); break;
            case 3: tRenderer.SetTexture(images[2]); break;
            case 4: tRenderer.SetTexture(images[3]); break;
            default: tRenderer.SetTexture(images[4]); break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.name == "Page2Trigger")
        {
            other.gameObject.SetActive(false);
            if (pollen == 0)
            {
                page2.gameObject.SetActive(true);
            }
        }
    }
}
