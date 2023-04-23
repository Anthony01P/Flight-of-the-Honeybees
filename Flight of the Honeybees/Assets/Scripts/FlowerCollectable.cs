using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerCollectable : MonoBehaviour
{
    public GameObject arrow;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            arrow.SetActive(false);
            this.gameObject.tag = "Collected";
        }
    }
}
