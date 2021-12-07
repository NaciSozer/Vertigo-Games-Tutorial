using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShotLesson.PlayerInput;

public class PlayerRotationSettings : MonoBehaviour
{
    [SerializeField] private PlayerInputData _inputData;

    [SerializeField]
    private Transform _tower;


    void Update()
    {
        _tower.Rotate(0, _inputData.horizontalInput, 0,Space.Self);
    }
}
