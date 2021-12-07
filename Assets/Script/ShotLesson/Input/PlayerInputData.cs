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
        public string AxisNameHorizontal;
        public string AxisNameVertical;

        [Header("Key Base Control")]
        [SerializeField] private bool _keyBaseHorizontalActive;
        public KeyCode PositiveHorizontalKeyCode;
        public KeyCode NegativeHorizontalKeyCode;
        [SerializeField] private bool _keyBaseVerticalActive;
        public KeyCode PositiveVericalKeyCode;
        public KeyCode NegativeVerticalKeyCode;
        public float lerpSpeed = 1;


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

            if(positiveActive && !negativeActive)
            {
                value = Mathf.Lerp(horizontalInput , 1 , Time.time * lerpSpeed);
            }

            else if(negativeActive && !positiveActive)
            {
                value = Mathf.Lerp(horizontalInput, -1, Time.time * lerpSpeed);
            }
            else
            {
                value = Mathf.Lerp(horizontalInput, 0, Time.time * lerpSpeed);
            }


        }
    }
}