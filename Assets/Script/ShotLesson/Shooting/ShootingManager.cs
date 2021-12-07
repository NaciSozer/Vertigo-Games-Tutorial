using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ShotLesson.Shooting
{


    public class ShootingManager : MonoBehaviour
    {
       
        public void Shooting(Vector3 from,Vector3 direction)
        {
            RaycastHit hit;

            bool rayHit = Physics.Raycast(transform.position, direction, out hit, Mathf.Infinity);
            
            if(rayHit)
            {
                Debug.Log(hit.collider.name);
            }
            Debug.DrawLine(transform.position, direction * 10, Color.red,2);

            var healthtStat = hit.collider.GetComponent<HealtManager>();

            if(healthtStat != null)
            {
                healthtStat.DeleteHealt(5);
            }

        }



    }
}