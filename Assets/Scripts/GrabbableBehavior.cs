using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static InteractionBehavior;


[RequireComponent(typeof(Rigidbody))]
public class GrabbableBehavior : MonoBehaviour
{

    public enum GrabType { None, Free, Snap };

    private Rigidbody rb;
    private GameObject grabber;
    private bool wasKinematic;
    private bool isHeld = false;

    public GrabType grabType = GrabType.Free;



    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        wasKinematic = rb.isKinematic;
        
    }


    public void TryGrab(GameObject grabber)
    {
        switch (grabType)
        {
            case GrabType.None:
                break;
            case GrabType.Free:
                GetComponent<Rigidbody>().isKinematic = true;
                transform.parent = grabber.transform;
                this.grabber = grabber;
                isHeld = true;
                break;
            case GrabType.Snap:
                GetComponent<Rigidbody>().isKinematic = true;
                transform.parent = grabber.transform;
                this.grabber = grabber;
                isHeld = true;
                transform.position = grabber.transform.position;
                transform.rotation = grabber.transform.rotation;
                break;
        }
    }


    public void TryRelease(GameObject grabber)
    {
        if (grabber.Equals(this.grabber) && isHeld)
        {
            transform.parent = null;
            rb.isKinematic = wasKinematic;
            isHeld = false;

        }
    }
}
