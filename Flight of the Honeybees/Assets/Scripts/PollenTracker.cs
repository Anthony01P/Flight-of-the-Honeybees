using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PollenTracker : MonoBehaviour
{
    public TMP_Text text;
    int pollenCount = new int();
    // Start is called before the first frame update
    void Start()
    {
        pollenCount = 0;
        text.text = "Pollen Count = 0";
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnTriggerEnter(Collider col){
            if(col.tag == "Pollen")
            {
                pollenCount += 1;
                col.gameObject.SetActive(false);
            text.text = "Pollen Count = " + pollenCount;
            }
        }
}
