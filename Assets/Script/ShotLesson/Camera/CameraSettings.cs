using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ShotLesson.LocalCamera
{ 

[CreateAssetMenu(menuName = ("ShotLesson/Camera/Camera Settings"))]
public class CameraSettings : ScriptableObject
{

    [Header("Rotation")]
    [SerializeField] private float _rotationLerpSpeed;

    public float RotationSpeed{get{ return _rotationLerpSpeed; } }


    [Header("Position")]
    [SerializeField] private Vector3 _positionOffset;

    public Vector3 PositionOffset { get { return _positionOffset; } }


    [SerializeField] private float _positionLerpSpeed;
    public float PositionLerpSpeed { get { return _positionLerpSpeed; } }

}
}