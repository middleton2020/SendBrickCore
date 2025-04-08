using CM.SendBrickCore.Interfaces.FunctionModules;
using CM.SendbrickShared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrickCore.FunctionModules.Inventory
{
    /// <summary>
    /// Store the collection of InventoryItemData records
    /// </summary>
    public class InventoryManager: IInventoryManager
    {
        private Dictionary<int, IInventoryItemData> _inventoryList = new Dictionary<int, IInventoryItemData>();
        private Dictionary<string, int> _inventoryIdIndex = new Dictionary<string, int>();

        private int _sequence = -1;

        /// <summary>
        /// Add an order to the list of orders.
        /// </summary>
        /// <param name="OrderData">Order object to add.</param>
        /// <returns>The zero-based index of the object in the list.</returns>
        public int AddItem(IInventoryItemData inpItemData)
        {
            _sequence += 1;
            _inventoryList.Add(_sequence, inpItemData);

            // Add to the dictionary too.
            string indexValue = inpItemData.SourceSystem.ToString() + inpItemData.InventoryId;
            _inventoryIdIndex.Add(indexValue, _sequence);

            return _sequence;
        }

        /// <summary>
        /// Get the specified order from the list.
        /// </summary>
        /// <param name="Instance">Zero-based index for the order in the list.</param>
        /// <returns>The order object.</returns>
        public IInventoryItemData GetItem(int Instance)
        {
            IInventoryItemData itemRecord = null;

            if (Instance < 0 || Instance > _sequence)
            {
                throw new IndexOutOfRangeException("There is no inventory item with ID " + Instance.ToString());
            }

            itemRecord = _inventoryList[Instance];
            if (itemRecord == null)
            {
                throw new KeyNotFoundException("No valid inventory item with ID " + Instance.ToString());
            }

            return itemRecord;
        }

        public bool HasItem(string inpItemId, SystemTypes.SourceSystemType inpSystemType)
        {
            string indexValue = inpSystemType.ToString() + inpItemId;
            return _inventoryIdIndex.ContainsKey(indexValue);
        }
        public bool HasItem(string inpItemId, ProductProperties.IdType inpIdType)
        {
            string indexValue = inpIdType.ToString() + inpItemId;
            return _inventoryIdIndex.ContainsKey(indexValue);
        }
        public bool HasItem(string indexValue)
        {
            return _inventoryIdIndex.ContainsKey(indexValue);
        }

        public IInventoryItemData GetItem(string inpItemId, SystemTypes.SourceSystemType inpSystemType)
        {
            string indexValue = inpSystemType.ToString() + inpItemId;
            return GetItem(indexValue);
        }
        public IInventoryItemData GetItem(string inpItemId, ProductProperties.IdType inpIdType)
        {
            string indexValue = inpIdType.ToString() + inpItemId;
            return GetItem(indexValue);
        }
        public IInventoryItemData GetItem(string indexValue)
        {
            if (_inventoryIdIndex.TryGetValue(indexValue, out int indexSequence))
            {
                IInventoryItemData inventryItem = _inventoryList[indexSequence];
                return inventryItem;
            }
            else
            {
                throw new KeyNotFoundException($"No Inventory item for ID: {indexValue}");
            }
        }
    }
}
