using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Destroy : MonoBehaviour
{
    public UnityEvent ruined;

    public void OnDestroy()
    {
        Destroy(gameObject);
        Debug.Log("Ahhhhhhh");
    }
}
