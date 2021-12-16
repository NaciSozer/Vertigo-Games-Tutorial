using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShotLesson.Inventory
{
    

    [CreateAssetMenu(menuName = ("ShotLesson/Player Inventory/Body Data"))]
    public class PlayerInventryBodyData : AbstractPlayerInvertoryData<PlayerInventoryBodyMono>
    {
        public override void CreatItem(InventoryController _inventoryController)
        {
            var InstantiatePrefab = InstantiarePrefabInToParent(_inventoryController.parent);

            
        }
    }
}