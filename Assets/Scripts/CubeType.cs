using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Cube Type",menuName = "Cube Type")]
public class CubeType : ScriptableObject
{
   public  Color cubeColor = Color.yellow;
   public Vector3 cubeScale = Vector3.one;
   
}
