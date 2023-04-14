using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameHandler : MonoBehaviour
{
    //Image GameObject
    public GameObject collected;
    //Collection of images for the "collected" object
    public Texture[] images;
    //Renderer of "collected" object
    public CanvasRenderer tRenderer;
    //Objective Variable
    public int flowers;

    // Start is called before the first frame update
    void Start()
    {
        //Assignment of Canvas Renderer to tRenderer
        tRenderer = collected.GetComponent<CanvasRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Checks for the current objective count and updates image according to value
        switch (flowers)
        {
            case 1: tRenderer.SetTexture(images[0]); break;
            case 2: tRenderer.SetTexture(images[1]); break;
            case 3: tRenderer.SetTexture(images[2]); break;
            case 4: tRenderer.SetTexture(images[3]); break;
            default: tRenderer.SetTexture(images[4]); break;
        }
    }
}
