using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class TeleporterBehavior : MonoBehaviour
{

    private bool canTeleport = false;
    private bool pointerVisible = false;

    private Vector3 destinationPoint = Vector3.zero;

    private LineRenderer lineRenderer;


    public float maxDistance = 5;
    public string floorTag = "Floor";
    public GameObject platformObj;

    private bool onPlatform = false;
    private bool platformTarget = false;

    public GameObject player;

    public Material okMaterial;
    public Material nokMaterial;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        HidePointer();
    }


    void HidePointer()
    {

        if (lineRenderer)
        {
            lineRenderer.enabled = false;
        }

        pointerVisible = false;
    }

    void ShowPointer()
    {
        if (lineRenderer)
        {
            lineRenderer.enabled = true;
        }
        pointerVisible = true;
    }

    void Teleport()
    {
        if (player)
        {
            player.transform.position = destinationPoint;
        }
    }

    // Update is called once per frame
    public void OnTeleportAction(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            ShowPointer();
        }
        if (context.canceled)
        {
            if (canTeleport)
            {
                onPlatform = false;

                if (platformTarget)
                {
                    destinationPoint = platformObj.transform.position;
                    onPlatform = true;
                }

                Teleport();

                
            }
            HidePointer();
        }
    }


    private void FixedUpdate()
    {
        platformTarget = false;

        if (onPlatform)
        {
            player.transform.position = platformObj.transform.position;
        }

        if (pointerVisible)
        {
            lineRenderer.SetPosition(0, transform.position);
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, maxDistance))
            {
                lineRenderer.SetPosition(1, transform.position + transform.forward * hit.distance);
            }
            else
            {
                lineRenderer.SetPosition(1, transform.position + transform.forward * maxDistance);
            }


            if (hit.collider && hit.collider.gameObject.CompareTag(floorTag))
            {
                canTeleport = true;
                lineRenderer.material = okMaterial;
                destinationPoint = hit.point;

                

                if (hit.collider.gameObject == platformObj)
                {
                    platformTarget = true;
                }
            }
            else
            {
                canTeleport = false;
                lineRenderer.material = nokMaterial;

            }

        }
    }

}
