using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatData22 : ScriptableObject
{
   public float value;
   

   public void UpdateValue(float number)
   {
      value += number;
      Debug.Log("Health has increased");
   }

   public void ReplaceValue(float number)
   {
      value = number;
   }
}
