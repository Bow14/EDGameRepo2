using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColorEvent : MonoBehaviour
{
    
    //Look backed on some color project code I did and remembered getComponet and renderer
    
    public UnityEvent colorStart;

    public Color green;

    public Renderer rend;

    public void Start()
    {
        rend = GetComponent<Renderer>();
    }

    public void OnMouseOver()
    {
        rend.material.color = Color.green;
    }
    

  
    
}
