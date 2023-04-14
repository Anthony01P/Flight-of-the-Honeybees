using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameHandler : MonoBehaviour
{
    public GameObject collected;
    public Texture[] images;
    public CanvasRenderer renderer;
    public int flowers;
    // Start is called before the first frame update
    void Start()
    {
        renderer = collected.GetComponent<CanvasRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (flowers)
        {
            case 1: renderer.SetTexture(images[0]); break;
            case 2: renderer.SetTexture(images[1]); break;
            case 3: renderer.SetTexture(images[2]); break;
            case 4: renderer.SetTexture(images[3]); break;
            default: renderer.SetTexture(images[4]); break;
        }
    }
}
