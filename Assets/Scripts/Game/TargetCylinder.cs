using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCylinder : MonoBehaviour
{
    public bool good = false;
    public Material newMaterial;

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Target touched");

        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Renderer>().material = newMaterial;

        good = true;

        
    }
}
