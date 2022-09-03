using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ColorData : ScriptableObject
{
  public Color hue;

  public void UpdateValue(Color rgb)
  {
    hue = Color.green;
  }
}
