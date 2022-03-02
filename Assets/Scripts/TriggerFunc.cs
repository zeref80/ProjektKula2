using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerFunc : MonoBehaviour
{
    public UnityEvent onTriggerEnterEvents;
    public UnityEvent onTriggerStayEvents;
    public UnityEvent onTriggerExitEvents;

    private void OnTriggerEnter(Collider other)
    {
        if(onTriggerEnterEvents != null)
        {
            onTriggerEnterEvents.Invoke();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (onTriggerStayEvents != null)
        {
            onTriggerStayEvents.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (onTriggerExitEvents != null)
        {
            onTriggerExitEvents.Invoke();
        }
    }
}
