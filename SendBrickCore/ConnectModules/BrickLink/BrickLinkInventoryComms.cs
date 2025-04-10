using CM.JsonTools;
using CM.SendBrickCore.Connectors;
using CM.SendBrickCore.FunctionModules.Inventory;
using CM.SendBrickCore.FunctionModules.Orders;
using CM.SendBrickCore.Interfaces.Connectors;
using CM.SendBrickCore.Interfaces.FunctionModules;
using CM.SendBrickCore.Interfaces.Tools;
using CM.SendBrickCore.Interfaces;
using CM.SendbrickShared.Enums;
using SendBrickCore.Interfaces.FunctionModules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrickCore.ConnectModules.BrickLink
{
    /// <summary>
    /// Commands to build InventoryItemData from BrickLink
    /// </summary>
    public class BrickLinkInventoryComs : IInventoryCommands
    {
        #region Fields
        private IInventoryManager _inventoryManager;
        BrickLinkInventoryApiTools apiController;
        // The controller class for handling connections.
        IApiConnect connectionControl;
        #endregion // Fields

        #region Constructors
        private BrickLinkInventoryComs()
        {
            _inventoryManager = new InventoryManager();
        }

        public BrickLinkInventoryComs(IInventoryManager inpInventoryManager)
        {
            _inventoryManager = inpInventoryManager;
        }

        /// <summary>
        /// Setup the connection tool.
        /// </summary>
        /// <param name="inpControlTools">System controller, where all control settings are initiated.</param>
        public BrickLinkInventoryComs(ISetControlTools inpControlTools) : this()
        {
            apiController = new BrickLinkInventoryApiTools(inpControlTools);
            connectionControl = new OAuth1Connect(inpControlTools);
        }
        /// <summary>
        /// Setup the connection tool.
        /// </summary>
        /// <param name="inpConnectionParams">Parameter controller, where system parameters are retreived, overriding the default.</param>
        public BrickLinkInventoryComs(IConnectionParameters inpConnectionParams) : this()
        {
            apiController = new BrickLinkInventoryApiTools(inpConnectionParams);
        }
        /// <summary>
        /// Setup the connection tool.
        /// </summary>
        /// <param name="inpConfigFile">Configuration file where the system parameters are stored, over-riding the default.</param>
        public BrickLinkInventoryComs(IConfigurationFile inpConfigFile) : this()
        {
            apiController = new BrickLinkInventoryApiTools(inpConfigFile);
        }

        /// <summary>
        /// Setup the connection tool.
        /// </summary>
        /// <param name="inpControlTools">System controller, where all control settings are initiated.</param>
        public BrickLinkInventoryComs(ISetControlTools inpControlTools, IInventoryManager inpInventoryManager) : this(inpInventoryManager)
        {
            apiController = new BrickLinkInventoryApiTools(inpControlTools);
        }
        /// <summary>
        /// Setup the connection tool.
        /// </summary>
        /// <param name="inpConnectionParams">Parameter controller, where system parameters are retreived, overriding the default.</param>
        public BrickLinkInventoryComs(IConnectionParameters inpConnectionParams, IInventoryManager inpInventoryManager) : this(inpInventoryManager)
        {
            apiController = new BrickLinkInventoryApiTools(inpConnectionParams);
        }
        /// <summary>
        /// Setup the connection tool.
        /// </summary>
        /// <param name="inpConfigFile">Configuration file where the system parameters are stored, over-riding the default.</param>
        public BrickLinkInventoryComs(IConfigurationFile inpConfigFile, IInventoryManager inpInventoryManager) : this(inpInventoryManager)
        {
            apiController = new BrickLinkInventoryApiTools(inpConfigFile);
        }
        #endregion // Constructors


        #region GetInventoryCommands
        public IInventoryItemData GetInventoryDataFor(string inpItemId)
        {
            IInventoryItemData inventoryItem = null;
            if (_inventoryManager.HasItem(inpItemId) == false)
            {
                inventoryItem = new InventoryItemData();
            }
            else
            {
                inventoryItem = _inventoryManager.GetItem(inpItemId, SystemTypes.SourceSystemType.BrickOwl);
            }

            string jsonData = apiController.GetInventoryDetails(inpItemId);
            BrickLinkInventoryDataExtract readerTool = new BrickLinkInventoryDataExtract();
            JsonReader jsonReader = new JsonReader(readerTool.MakeObject,
                readerTool.CloseObject, readerTool.MakeArray, readerTool.CloseArray,
                readerTool.SetField, readerTool.SetField, readerTool.SetField, readerTool.SetField);
            inventoryItem = (IInventoryItemData)jsonReader.ReadJson(jsonData, inventoryItem);

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

        public void CreateInventoryData(IInventoryItemData inpInventoryItem)
        {
            throw new NotImplementedException();
        }

        public void DeleteInventoryData(IInventoryItemData inpInventoryItem)
        {
            throw new NotImplementedException();
        }

        public void GetFullInventory(ref IInventoryManager inpInventory)
        {
            throw new NotImplementedException();
        }

        public void UpdateInventoryData(IInventoryItemData inpInventoryItem)
        {
            throw new NotImplementedException();
        }

        public void CreateOrderData(IOrderData inpOrderData)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrderData(IOrderData inpOrderData)
        {
            throw new NotImplementedException();
        }

        public void GetOutstandingOrders(ref IOrderManager inpOrders)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrderData(IOrderData inpOrderData)
        {
            throw new NotImplementedException();
        }
        #endregion // UpdateOrderCommands
    }
}