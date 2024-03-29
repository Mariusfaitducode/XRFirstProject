using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class InputsBehavior : MonoBehaviour
{

    public Animator rightAnimator;
    public GameObject rightThumbstick;

    public void OnAPressed(InputAction.CallbackContext context)
    {

        if (context.started)
        {
            Debug.Log("A Pressed");
            if (rightAnimator)
            {
                rightAnimator.SetBool("Apressed", true);
            }
        }
        if (context.canceled)
        {
            Debug.Log("A Released");
            if (rightAnimator)
            {
                rightAnimator.SetBool("Apressed", false);
            }
        }


    }
    public void OnBPressed(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("B Pressed");
            if (rightAnimator)
            {
                rightAnimator.SetBool("Bpressed", true);
            }
        }
        if (context.canceled)
        {
            Debug.Log("B Released");
            if (rightAnimator)
            {
                rightAnimator.SetBool("Bpressed", false);
            }
        }
    }

    public void OnTriggerAxis(InputAction.CallbackContext context)
    {
        if (rightAnimator)
        {
            rightAnimator.SetFloat("RightTrig", context.ReadValue<float>());
        }
    }

    public void RightThumbstick(InputAction.CallbackContext context)
    {
        if (rightThumbstick)
        {
            Vector2 thumbstickValue = context.ReadValue<Vector2>();
            rightThumbstick.transform.localEulerAngles = new Vector3(thumbstickValue.y, 0, -
           thumbstickValue.x) * 15f;
        }
    }


    
}
