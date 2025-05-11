using System.Collections.Generic;
using UnityEngine;

using _TSS.Item;

namespace _TSS.Shop
{
    [CreateAssetMenu(fileName = "ShopFile", menuName = "_TSS/Shop", order = 0)]
    public class Shop : ScriptableObject
    {
        [field: SerializeField] public List<ShopItem> ShopItems { get; private set; }

        //There would be a factory where you can obtain all saved shops and their shoptitem saved
        
        [System.Serializable]
        public class ShopItem
        {
            public int Count { get; private set; }
            public Item.Item Item {get; private set; }
        }
    }

}