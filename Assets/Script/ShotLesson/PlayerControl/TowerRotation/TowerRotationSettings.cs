using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShotLesson.PlayerControls
{

    [CreateAssetMenu(menuName = ("ShotLesson/Player Input/Tower Input Data"))]
    public class TowerRotationSettings : ScriptableObject
    {

        public float towerRotationSpeed = 1.0f;
        
    }
}