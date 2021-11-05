using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Lesson/Rotate")]
public class CubeData : ScriptableObject
{

    [SerializeField] int _speed;
    public int Speed { get { return _speed; } }




}
