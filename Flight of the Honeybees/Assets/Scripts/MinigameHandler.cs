using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameHandler : MonoBehaviour
{
    public GameObject collected;
    public SpriteRenderer spriteRender;
    public Sprite[] sprites;
    public int pollen;
    // Start is called before the first frame update
    void Start()
    {
        spriteRender = collected.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (pollen)
        {
            case 1: spriteRender.sprite = sprites[0]; break;
            case 2: spriteRender.sprite = sprites[1]; break;
            case 3: spriteRender.sprite = sprites[2]; break;
            case 4: spriteRender.sprite = sprites[3]; break;
            default: spriteRender.sprite = sprites[4]; break;
        }
    }
}
