using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtManager : MonoBehaviour
{

    public int healt = 100;

    public void DeleteHealt(int damage)
    {
        healt -= damage;

        if(healt <= 0)
        {
            Debug.Log(damage);
        }

        else
        {
            Debug.Log("Real healt" + healt);
        }
    }



}
