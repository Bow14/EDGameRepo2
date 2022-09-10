using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VoiceEvent : MonoBehaviour
{
    // GUI Docs was where I saw this
    public UnityEvent speak;
    public void OnGUI()
    {
        Event s = Event.current;
        if (s.shift)
        {
            Debug.Log("I cannot run at full speed!");
        }
    }
}
