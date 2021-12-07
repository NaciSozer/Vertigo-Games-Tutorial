using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShotLesson.PlayerInput
{



    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private PlayerInputData[] _inputDataArray;
        

        void Update()
        {
            for (int i = 0; i < _inputDataArray.Length; i++)
            {
                _inputDataArray[i].ProcsesInput(); 

            }

        }
    }
}