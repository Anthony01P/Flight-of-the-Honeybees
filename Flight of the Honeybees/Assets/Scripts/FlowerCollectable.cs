using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerCollectable : MonoBehaviour
{
    public GameObject arrow;
    public AudioSource collectedPollen;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            collectedPollen.Play();
            arrow.SetActive(false);
            this.gameObject.tag = "Collected";
        }
    }
}
