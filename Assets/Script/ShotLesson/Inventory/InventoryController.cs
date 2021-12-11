using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShotLesson.Inventory
{


    public class InventoryController : MonoBehaviour
    {
        [SerializeField] AbstrackPlayerInventoryDataBase[] _itemdata;
        public Transform parent;
        void Start()
        {
            InitializeInvertory(_itemdata);

        }

       public void InitializeInvertory(AbstrackPlayerInventoryDataBase[] itemdata)
        {


            for (int i = 0; i < _itemdata.Length; i++)
            {
                itemdata[i].CreatItem(this);
            }

        }
    }
}