using CM.SendbrickShared.Enums;

namespace CM.SendBrickCore.Interfaces.FunctionModules
{
    /// <summary>
    /// Stores the data of each item in the inventory
    /// </summary>
    public interface IInventoryItemData
    {
        decimal BasePrice { get; set; }
        int BindId { get; set; }
        int Bulk { get; set; }
        int ColourCode { get; set; }
        string ColourName { get; set; }
        string Comments { get; set; }
        DateTime DateCreated { get; set; }
        string Description { get; set; }
        decimal FinalPrice { get; set; }
        string InventoryId { get; set; }
        bool IsRetained { get; set; }
        bool IsStockRoom { get; set; }
        ProductProperties.Condition ItemCondition { get; set; }
        string LegoCategory { get; set; }
        string LegoDescription { get; set; }
        string LegoNumber { get; set; }
        string LegoType { get; set; }
        string Location { get; set; }
        string PermaLink { get; set; }
        decimal PurchasePrice { get; set; }
        int Quantity { get; set; }
        int ReservedIt { get; set; }
        double SalePercent { get; set; }
        decimal SalePrice { get; set; }
        int SaleRate { get; set; }
        SystemTypes.SourceSystemType SourceSystem { get; set; }
        string Url { get; set; }
        decimal Weight { get; set; }

        int PriceTierQuantity { get; set; }
        decimal PriceTierPrice { get; set; }

        SystemTypes.SourceSystemType AltIdSourceSystem { get; set; }
        string AlternateIdName { get; set; }
        string AlternateIdValue { get; set; }

        void AddPriceTier();
        void AddAlternateId();

        bool FindFirstAlternateId();
        bool FindFirstPriceTier();
        bool FindLastAlternateId();
        bool FindLastPriceTier();
        bool FindNextAlternateId();
        bool FindNextPriceTier();
        bool FindPrevAlternateId();
        bool FindPrevPriceTier();
        bool FindSpecificAlternateId(int inpAltIdIndex);
        bool FindSpecificPriceTier(int inpTierIndex);
    }
}
