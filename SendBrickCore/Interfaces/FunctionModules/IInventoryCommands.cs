using CM.SendBrickCore.FunctionModules.Inventory;
using CM.SendBrickCore.Interfaces.FunctionModules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendBrickCore.Interfaces.FunctionModules
{
    /// <summary>
    /// Commands to build InventoryItemData from an API interface
    /// </summary>
    public interface IInventoryCommands
    {
        void CreateInventoryData(IInventoryItemData inpInventoryItem);
        void DeleteInventoryData(IInventoryItemData inpInventoryItem);
        void GetFullInventory(ref IInventoryManager inpInventory);
        IInventoryItemData GetInventoryDataFor(string inpItemId);
        void UpdateInventoryData(IInventoryItemData inpInventoryItem);

        void CreateOrderData(IOrderData inpOrderData);
        void DeleteOrderData(IOrderData inpOrderData);
        void GetOutstandingOrders(ref IOrderManager inpOrders);
        IOrderData GetOrderDataFor(string inpOrdereId);
        void UpdateOrderData(IOrderData inpOrderData);
    }
}
