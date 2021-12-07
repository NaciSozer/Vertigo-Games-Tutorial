using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ShotLesson.PlayerControls
{
    [CreateAssetMenu(menuName ="ShotLesson/Player Movement/Movement Settings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        public float _horiontalSpeed = 0.1f;
        public float _verticalSpeed = 0.1f;



    }
}