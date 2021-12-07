using System.Collections;
using System.Collections.Generic;
using ShotLesson.PlayerInput;
using UnityEngine;


namespace ShotLesson.PlayerControls
{

    public class TowerRotationController : MonoBehaviour
    {
        [SerializeField] PlayerInputData _rotationData;
        [SerializeField] Transform _towerRotation;
        [SerializeField] TowerRotationSettings _towerRotationSettings;



        void Update()
        {

            _towerRotation.Rotate(0, _rotationData.horizontalInput * _towerRotationSettings.towerRotationSpeed, 0);

        }
    }
}