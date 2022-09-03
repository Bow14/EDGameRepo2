using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class IntChangeData : ScriptableObject
{
   public int value;

   public void UpdateValue(int number)
   {
      value += number;
   }

   public void Replacevalue(int number)
   {
      value = number;
   }
}
