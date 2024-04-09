using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[RequireComponent(typeof(Rigidbody))]
public class TriggerBehavior : MonoBehaviour
{


    public UnityEvent onTriggerEvent;


    public void Trigger()
    {
        onTriggerEvent.Invoke();
    }
}
