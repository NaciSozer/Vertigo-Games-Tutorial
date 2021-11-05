using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{

    [SerializeField] CubeData cubeData;


    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(Vector3.up * cubeData.Speed * Time.deltaTime);
    }
}
