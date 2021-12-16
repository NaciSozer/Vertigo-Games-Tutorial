using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShotLesson
{


    public class AbstractScriptableManager<T> : AbstractScriptableManagerBase where T: AbstractScriptableManager<T>
    {
        public static T instance;


        public override void Initialize()
        {
            base.Initialize();
            instance = this as T;
        }

        public override void Destroy()
        {
            base.Destroy();

        }

    }
}