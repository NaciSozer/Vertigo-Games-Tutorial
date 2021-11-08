using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShotLesson.PlayerInput
{



    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] PlayerInputData _playerInputData;


        
        void Update()
        {
            _playerInputData.horizontalInput = Input.GetAxis("Horizontal");

            _playerInputData.verticalInput = Input.GetAxis("Vertical");
        }
    }
}