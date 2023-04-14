using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveMarkerScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(transform.position + Camera.current.transform.rotation * Vector3.forward, Camera.current.transform.rotation * Vector3.up);
    }
}
