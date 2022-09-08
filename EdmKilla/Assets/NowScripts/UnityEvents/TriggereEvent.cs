using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TriggereEvent : MonoBehaviour
{
    public UnityEvent triggereEnterEvent;  
    public void OnTriggerEnter(Collider other)
    {
        triggereEnterEvent.Invoke();
    }
}
