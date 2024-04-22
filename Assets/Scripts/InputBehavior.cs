using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class InputsBehavior : MonoBehaviour
{

    public Animator rightAnimator;
    public Animator leftAnimator;
    public Animator rightHandAnimator;
    public Animator leftHandAnimator;
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

    public void OnXPressed(InputAction.CallbackContext context)
    {

        if (context.started)
        {
            Debug.Log("X Pressed");
            if (leftAnimator)
            {
                leftAnimator.SetBool("Xpressed", true);
            }
        }
        if (context.canceled)
        {
            Debug.Log("X Released");
            if (leftAnimator)
            {
                leftAnimator.SetBool("Xpressed", false);
            }
        }


    }
    public void OnYPressed(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("Y Pressed");
            if (leftAnimator)
            {
                leftAnimator.SetBool("Ypressed", true);
            }
        }
        if (context.canceled)
        {
            Debug.Log("Y Released");
            if (leftAnimator)
            {
                leftAnimator.SetBool("Ypressed", false);
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

    public void OnLeftTriggerAxis(InputAction.CallbackContext context)
    {
        if (leftAnimator)
        {
            Debug.Log("left trigger");
            leftAnimator.SetFloat("LeftTrig", context.ReadValue<float>());
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

    public void OnRightGripAxis(InputAction.CallbackContext context)
    {
        if (rightHandAnimator)
        {
            rightHandAnimator.SetFloat("Close", context.ReadValue<float>());
        }
    }
    public void OnRightTriggerTouch(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if (rightHandAnimator)
            {
                rightHandAnimator.SetBool("Point", false);
            }
        }
        if (context.canceled)
        {
            if (rightHandAnimator)
            {
                rightHandAnimator.SetBool("Point", true);
            }
        }
    }

    public void OnLeftGripAxis(InputAction.CallbackContext context)
    {
        if (leftHandAnimator)
        {
            leftHandAnimator.SetFloat("Close", context.ReadValue<float>());
        }
    }
    public void OnLeftTriggerTouch(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if (leftHandAnimator)
            {
                leftHandAnimator.SetBool("Point", false);
            }
        }
        if (context.canceled)
        {
            if (leftHandAnimator)
            {
                leftHandAnimator.SetBool("Point", true);
            }
        }
    }


}
