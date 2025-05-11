using UnityEngine;

namespace _TSS.Shop
{
    public class Shopper : MonoBehaviour
    {
        [SerializeField] private Shop shopData;

        //Esto se podria hacer un metodo de extension y solo pedir datos primitivos en esta clase
        //No lo se, puro pensar a esta hora me tiene bastante cansado 11:20pm
        
        public bool TryShop(IShopClient client, Item.Item itemToShop)
        {
            if (client.CurrentCurrency < itemToShop.Price) return false;
            
            client.OnItemBuy(itemToShop);
            return true;
        }
    }
}