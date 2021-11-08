using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRigidBody : MonoBehaviour
{
    [SerializeField] Rigidbody myBody;
    [SerializeField] RigidbodyData rigiData;
    void Start()
    {
        myBody = GetComponent<Rigidbody>();
    }

    
    void Update()
    {

        bool spaceKeyDown = Input.GetKeyDown(KeyCode.Space);

        if (spaceKeyDown)
        {
            myBody.AddForce(rigiData.jumpPower, ForceMode.Impulse);
        }

        


    }
}
