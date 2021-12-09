using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShotLesson.Shooting;

namespace ShotLesson.LocalCamera
{

public class CameraControllers : MonoBehaviour
{
    [SerializeField] CameraSettings _cameraSettings;
    [SerializeField] private Transform _rotationTransform;
    [SerializeField] private Transform _positionTarget;
    [SerializeField] private Transform _cameraTransform;
    public ShootingManager _shootingManager;
    private void Update()
    {
            CameraPositionFollow();
            CameraRotationFollow();
        

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _shootingManager.Shooting(_cameraTransform.position, _cameraTransform.forward);

               
            }



            
    }

    private void CameraRotationFollow()
    {
        _cameraTransform.rotation = Quaternion.Lerp(
            _cameraTransform.rotation,
            Quaternion.LookRotation(_rotationTransform.forward),
            Time.deltaTime * _cameraSettings.RotationSpeed);
    }

    private void CameraPositionFollow()
    {
            _cameraTransform.localPosition = _cameraSettings.PositionOffset;


    }


}
}