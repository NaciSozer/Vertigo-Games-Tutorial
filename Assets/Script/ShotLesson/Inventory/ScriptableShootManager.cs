using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShotLesson.Inventory
{

    [CreateAssetMenu(menuName = "ShotLesson/Inventory/ScriptableShootManager")]
    public class ScriptableShootManager : AbstractScriptableManager<ScriptableShootManager>
    {

        public override void Initialize()
        {
            Debug.Log("Creat");
        }

        public override void Destroy()
        {
            Debug.Log("Destroy");
        }




    }
}