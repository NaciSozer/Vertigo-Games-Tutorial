using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShotLesson.PlayerInput
{



    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] PlayerInputData _playerInputData;
        [SerializeField] PlayerInputData _playerRotationInputData;
        [SerializeField] private Vector3 _lastMouseInput;


        void Update()
        {
            _playerInputData.horizontalInput = Input.GetAxis("Horizontal");

            _playerInputData.verticalInput = Input.GetAxis("Vertical");


            _playerRotationInputData.horizontalInput = (Input.mousePosition.x - _lastMouseInput.x);
            _lastMouseInput = Input.mousePosition;

        }
    }
}