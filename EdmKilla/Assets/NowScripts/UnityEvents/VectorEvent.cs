using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VectorEvent : MonoBehaviour
{
    public UnityEvent teleport;
    public Vector3 schmoove;


    public void OnEnable()
    {
        teleport.Invoke();
        schmoove = Vector3.left;

    }
}
