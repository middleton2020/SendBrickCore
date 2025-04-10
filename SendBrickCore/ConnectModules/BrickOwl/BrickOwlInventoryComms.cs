using CM.SendBrickCore.FunctionModules.Inventory;
using CM.SendBrickCore.FunctionModules.Orders;
using CM.SendBrickCore.Interfaces.FunctionModules;
using CM.SendbrickShared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrickCore.ConnectModules.BrickOwl
{
    /// <summary>
    /// Commands to build InventoryItemData from BrickOwl
    /// </summary>
    public class BrickOwlInventoryComms
    {
        #region Fields
        private IInventoryManager _inventoryManager;
        #endregion // Fields
        #region Constructors
        public BrickOwlInventoryComms()
        {
            _inventoryManager = new InventoryManager();
        }
        public BrickOwlInventoryComms(IInventoryManager inpInventoryManager)
        {
            _inventoryManager = inpInventoryManager;
        }
        #endregion // Constructors

        #region GetInventoryCommands
        public IInventoryItemData GetInventoryDataFor(string inpItemId)
        {
            IInventoryItemData inventoryItem = null;
            if (_inventoryManager.HasItem(inpItemId))
            {
                inventoryItem = new InventoryItemData();
            }
            else
            {
                inventoryItem = _inventoryManager.GetItem(inpItemId, SystemTypes.SourceSystemType.BrickOwl);
            }

            return inventoryItem;
        }
        public void GetFullInventory(ref InventoryManager inpInventory)
        {
            throw new NotImplementedException();
        }
        #endregion // GetInventoryCommands

        #region UpdateInventoryCommands
        public void CreateInventoryData(InventoryItemData inpInventoryItem)
        {
            throw new NotImplementedException();
        }
        public void DeleteInventoryData(InventoryItemData inpInventoryItem)
        {
            throw new NotImplementedException();
        }
        public void UpdateInventoryData(InventoryItemData inpInventoryItem)
        {
            throw new NotImplementedException();
        }
        #endregion // UpdateInventoryCommands

        #region GetOrderCommands
        public IOrderData GetOrderDataFor(string inpOrdereId)
        {
            throw new NotImplementedException();
        }

        public void GetOutstandingOrders(ref OrderManager inpOrders)
        {
            throw new NotImplementedException();
        }
        #endregion // GetOrderCommands

        #region UpdateOrderCommands
        public void CreateOrderData(OrderData inpOrderData)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrderData(OrderData inpOrderData)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrderData(OrderData inpOrderData)
        {
            throw new NotImplementedException();
        }
        #endregion // UpdateOrderCommands
    }
}
