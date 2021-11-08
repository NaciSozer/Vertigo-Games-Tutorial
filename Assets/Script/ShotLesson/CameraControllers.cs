using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllers : MonoBehaviour
{
    [SerializeField] CameraSettings _cameraSettings;
    [SerializeField] private Transform _targetTransform;
    [SerializeField] private Transform _cameraTransform;
    
    private void Update()
    {
        CameraRotationFollow();
        CameraPositionFollow();
    }

    private void CameraRotationFollow()
    {
        _cameraTransform.rotation = Quaternion.Lerp(
            _cameraTransform.rotation,
            Quaternion.LookRotation(_targetTransform.position - _cameraTransform.position),
            Time.deltaTime * _cameraSettings.RotationSpeed);
    }

    private void CameraPositionFollow()
    {
        _cameraTransform.position = Vector3.Lerp(_cameraTransform.position,
            _targetTransform.position + _cameraSettings.PositionOffset,
           Time.deltaTime * _cameraSettings.PositionLerpSpeed);


    }


}
