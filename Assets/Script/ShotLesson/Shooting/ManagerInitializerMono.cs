using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShotLesson
{


    public class ManagerInitializerMono : MonoBehaviour
    {
        [SerializeField] private AbstractScriptableManagerBase[] _abstracScriptableManagerArray;
        private List<AbstractScriptableManagerBase> _instantiatedAbstractScriptManagerList;


        
        void Start()
        {

            _instantiatedAbstractScriptManagerList = new List<AbstractScriptableManagerBase>(_abstracScriptableManagerArray.Length);
            for (int i = 0; i < _abstracScriptableManagerArray.Length; i++)
            {

                var instantiated = Instantiate(_abstracScriptableManagerArray[i]);
                instantiated.Initialize();
                _instantiatedAbstractScriptManagerList.Add(instantiated);
            }
        }


        private void OnDestroy()
        {
            
            if(_instantiatedAbstractScriptManagerList != null)
            {

                for (int i = 0; i < _instantiatedAbstractScriptManagerList.Count; i++)
                {
                    _instantiatedAbstractScriptManagerList[i].Destroy();

                }

            }


        }

    }
}