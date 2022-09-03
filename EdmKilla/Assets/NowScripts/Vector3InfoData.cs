using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Vector3InfoData : ScriptableObject
{
   public Vector3 infoValue;

   public void UpdateValue(Transform vec)
   {
      infoValue = vec.position;
   }
}
