using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShotLesson.Shooting;

namespace ShotLesson.LocalCamera
{

public class CameraControllers : MonoBehaviour
{
    [SerializeField] CameraSettings _cameraSettings;
    [SerializeField] private Transform _targetTransform;
    [SerializeField] private Transform _cameraTransform;
        public ShootingManager _shootingManager;
    private void Update()
    {
        CameraRotationFollow();
        CameraPositionFollow();

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _shootingManager.Shooting(_cameraTransform.position, _cameraTransform.forward);

               
            }



            
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
}