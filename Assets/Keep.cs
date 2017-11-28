using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keep : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision);
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
