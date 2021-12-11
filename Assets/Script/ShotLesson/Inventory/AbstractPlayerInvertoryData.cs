using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShotLesson.Inventory
{
    public enum InventoryItemData { Cannon, Body }
    public abstract class AbstractPlayerInvertoryData<T> : AbstrackPlayerInventoryDataBase where T : 
        AbscratcPlayerInventoryMono
    {
        [SerializeField] protected string ItemId;
        [SerializeField] protected InventoryItemData _inventoryItemDara;
        [SerializeField] protected T _prefab;
        
        
        protected T InstantiarePrefabInToParent(Transform parent)
        {
           return Instantiate(_prefab, parent);
        }
        
        
    }
}