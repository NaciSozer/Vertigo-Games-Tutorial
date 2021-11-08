using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Lesson/Rigidbody")]
public class RigidbodyData : ScriptableObject
{

    [SerializeField] private Vector3 _jumpPower;

    public Vector3 jumpPower { get { return _jumpPower; } }




}
