namespace _TSS.Shop
{
    public interface IShopClient
    {
        public int CurrentCurrency { get; set; }

        public void OnItemBuy(Item.Item item);
    }
}