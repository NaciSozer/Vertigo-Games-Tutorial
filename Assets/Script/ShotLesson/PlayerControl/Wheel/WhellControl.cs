using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShotLesson.PlayerInput
{


    public class WhellControl : MonoBehaviour
    {
        [SerializeField] PlayerInputData _playerInput;
        [SerializeField] GameObject[] _whell;
        [SerializeField] bool _inputControl;


        void Update()
        {
            if(_playerInput.verticalInput != 0)
            {
                _inputControl = true;

                if (_inputControl)
                {
                    if (_playerInput.verticalInput < 1.1f)
                    {

                        for (int i = 0; i < _whell.Length; i++)
                        {
                            _whell[i].transform.Rotate(Vector3.right);


                        }


                    }
                    else if (_playerInput.verticalInput > -1)
                    {
                        for (int i = 0; i < _whell.Length; i++)
                        {
                            _whell[i].transform.Rotate(Vector3.left);


                        }

                    }
                }


            }
            else if(_playerInput.verticalInput == 0)
            {
                _inputControl = false;

                if (!_inputControl)
                {
                    for (int i = 0; i < _whell.Length; i++)
                    {
                        _whell[i].transform.Rotate(Vector3.zero);

                    }
                }
            }

            Debug.Log(_inputControl);
            
        }
    }
}