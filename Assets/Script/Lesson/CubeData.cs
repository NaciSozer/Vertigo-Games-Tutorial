using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Lesson/Rotate")]
public class CubeData : ScriptableObject
{

    [SerializeField] private int _speed;
    public int Speed { get { return _speed; } }

    [SerializeField] Color _color;

    public Color color { get { return _color; } }



}
