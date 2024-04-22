using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MatchBlockAndSphere : MonoBehaviour
{
    public GameObject matchingSphere;
    public bool good = false;

    private void OnTriggerEnter(Collider other)
    {
        
        if (matchingSphere != null && other.gameObject == matchingSphere) {

            Debug.Log("Object match");

            this.transform.localScale = new Vector3(this.transform.localScale.x, 2, this.transform.localScale.z); 
            other.gameObject.SetActive(false);
            good = true;
        
        }
    }
}
