namespace CM.SendBrickCore.Interfaces.FunctionModules
{
    public interface IOrderItemData
    {
        string ItemCountryOfOrigin { get; set; }
        string ItemDescription { get; set; }
        string ItemHsCode { get; set; }
        string ItemId { get; set; }
        string ItemImageUrl { get; set; }
        int ItemQuantity { get; set; }
        string ItemSkuCode { get; set; }
        double ItemValue { get; set; }
        double ItemWeight { get; set; }
        int ParcelInstance { get; set; }
    }
}