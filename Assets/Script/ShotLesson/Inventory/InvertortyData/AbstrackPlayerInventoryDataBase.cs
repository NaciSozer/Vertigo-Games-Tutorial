using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShotLesson.Inventory
{
    public abstract class AbstrackPlayerInventoryDataBase : ScriptableObject
    {

        public abstract void CreatItem(InventoryController _inventoryController);

    }
}