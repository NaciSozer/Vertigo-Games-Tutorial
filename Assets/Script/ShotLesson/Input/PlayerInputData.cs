using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ShotLesson.PlayerInput
{
    [CreateAssetMenu(menuName =("ShotLesson/Player Input/Input Data"))]
    public class PlayerInputData : ScriptableObject
    {

        public float horizontalInput;
        public float verticalInput;
    }
}