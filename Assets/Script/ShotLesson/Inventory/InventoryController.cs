using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShotLesson.Inventory
{


    public class InventoryController : MonoBehaviour
    {
        [SerializeField] AbstrackPlayerInventoryDataBase[] _itemdata;
        private List<AbstrackPlayerInventoryDataBase> _instantiatedItemDataList;
        public Transform parent;
        void Start()
        {
            InitializeInvertory(_itemdata);

        }

        private void OnDestroy()
        {
            ClrearInventory();
        }

        public void InitializeInvertory(AbstrackPlayerInventoryDataBase[] itemdata)
        {

            ClrearInventory();

            _instantiatedItemDataList = new List<AbstrackPlayerInventoryDataBase>();

            for (int i = 0; i < _itemdata.Length; i++)
            {
                var instantiated = Instantiate(_itemdata[i]);

                instantiated.CreatItem(this);
            }

        }

        private void ClrearInventory()
        {
            if (_instantiatedItemDataList != null)
            {
                for (int i = 0; i < _instantiatedItemDataList.Count; i++)
                {
                    _instantiatedItemDataList[i].Destroy();
                }
            }
        }
    }
}