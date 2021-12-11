using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShotLesson.Inventory
{

    [CreateAssetMenu(menuName = ("ShotLesson/Player Inventory/Canon Data"))]
    public class PlayerInventryCanonData : AbstractPlayerInvertoryData<PlayerInventoryCanonMono>
    {
        public override void CreatItem(InventoryController _inventoryController)
        {

            var InstantiatePrefab = InstantiarePrefabInToParent(_inventoryController.parent);
        }
    }
}