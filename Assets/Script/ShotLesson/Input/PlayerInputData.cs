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



        [Header("Axis Base Control")]
        [SerializeField] private bool _axisActive;
        [SerializeField] private string AxisNameHorizontal;
        [SerializeField] private string AxisNameVertical;

        [Header("Key Base Control")]
        [SerializeField] private bool _keyBaseHorizontalActive;
        [SerializeField] private KeyCode PositiveHorizontalKeyCode;
        [SerializeField] private KeyCode NegativeHorizontalKeyCode;
        [SerializeField] private bool _keyBaseVerticalActive;
        [SerializeField] private KeyCode PositiveVericalKeyCode;
        [SerializeField] private KeyCode NegativeVerticalKeyCode;
        [SerializeField] private float _increaseAmount = 0.15f;

        public void ProcsesInput()
        {

            if (_axisActive)
            {
                horizontalInput = Input.GetAxis(AxisNameHorizontal);
                verticalInput = Input.GetAxis(AxisNameVertical);
            }

            else
            {

                if (_keyBaseHorizontalActive)
                {
                    KeyBaseAxisControl(ref horizontalInput, PositiveHorizontalKeyCode, NegativeHorizontalKeyCode);
                }
                if (_keyBaseVerticalActive)
                {
                    KeyBaseAxisControl(ref verticalInput, PositiveVericalKeyCode, NegativeVerticalKeyCode);
                }

            }


        }

        public void KeyBaseAxisControl(ref float value,KeyCode positive,KeyCode negative)
        {

            bool positiveActive = Input.GetKey(positive);
            bool negativeActive = Input.GetKey(negative);

            if(positiveActive)
            {
                value += _increaseAmount;
            }

            else if(negativeActive)
            {
                value -= _increaseAmount;
            }
            else
            {
                value = 0;
            }

            value = Mathf.Clamp(value, -1, 1);
        }
    }
}