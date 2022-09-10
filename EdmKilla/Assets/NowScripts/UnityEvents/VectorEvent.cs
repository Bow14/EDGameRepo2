using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VectorEvent : MonoBehaviour
{
    public UnityEvent teleport;
    public Vector3 schmoove;


    public void OnMouseOver()
    {
        schmoove.Set(0, 50, 0);
        teleport.Invoke();
    }

    public void moveDat()
    {
        schmoove.Set(0, 50, 0);
        teleport.Invoke();
        
    }

    //


    // public void Vector3()
    // {
    //   teleport.Invoke();  
    // }
}
