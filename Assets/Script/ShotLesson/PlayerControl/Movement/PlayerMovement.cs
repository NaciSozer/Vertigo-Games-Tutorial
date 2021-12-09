using System.Collections;
using System.Collections.Generic;
using ShotLesson.PlayerInput;
using UnityEngine;


namespace ShotLesson.PlayerControls
{

    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] Rigidbody _rigibody;
        [SerializeField] PlayerInputData _playerInput;
        [SerializeField] Transform _targetTransform;
        [SerializeField] PlayerMovementSettings _playerMovementSpeed;

        private void Update()
        {

            _rigibody.MovePosition(_rigibody.position +(_rigibody.transform.forward * _playerInput.verticalInput * _playerMovementSpeed._verticalSpeed));
            _targetTransform.Rotate(0, _playerInput.horizontalInput * _playerMovementSpeed._horiontalSpeed, 0,Space.Self);

        }

    }
}