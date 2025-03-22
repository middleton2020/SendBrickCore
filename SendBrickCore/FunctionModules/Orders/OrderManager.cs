using CM.SendBrickCore.Interfaces.FunctionModules;
using CM.SendbrickShared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrickCore.FunctionModules.Orders
{
    /// <summary>
    /// Store the collection of TransferOrderData records
    /// </summary>
    public class OrderManager : IOrderManager
    {
        private Dictionary<int, IOrderData> _ordersList = new Dictionary<int, IOrderData>();
        private Dictionary<string, int> _orderIdIndex = new Dictionary<string, int>();
        private int _sequence = -1;

        /// <summary>
        /// Add an order to the list of orders.
        /// </summary>
        /// <param name="OrderData">Order object to add.</param>
        /// <returns>The zero-based index of the object in the list.</returns>
        public int AddOrder(IOrderData inpOrderData)
        {
            _sequence += 1;
            _ordersList.Add(_sequence, inpOrderData);

            // Add to the dictionary too.
            string indexValue = inpOrderData.SourceSystem.ToString() + inpOrderData.SupplierId;
            _orderIdIndex.Add(indexValue, _sequence);

            return _sequence;
        }

        /// <summary>
        /// Get the specified order from the list.
        /// </summary>
        /// <param name="inpInstance">Zero-based index for the order in the list.</param>
        /// <returns>The order object.</returns>
        public IOrderData GetOrder(int inpInstance)
        {
            IOrderData orderRecord = null;

            if (inpInstance < 0 || inpInstance > _sequence)
            {
                throw new IndexOutOfRangeException("There is no order with ID " + inpInstance.ToString());
            }

            orderRecord = _ordersList[inpInstance];
            if (orderRecord == null)
            {
                throw new KeyNotFoundException("No valid order with ID " + inpInstance.ToString());
            }

            return orderRecord;
        }

        public bool HasOrder(string inpOrderId, SystemTypes.SourceSystemType inpSourceSystem)
        {
            string indexValue = inpSourceSystem.ToString() + inpOrderId;
            return _orderIdIndex.ContainsKey(indexValue);
        }
        public bool HasOrder(string inpOrderId, ProductProperties.IdType inpIdType)
        {
            string indexValue = inpIdType.ToString() + inpOrderId;
            return _orderIdIndex.ContainsKey(indexValue);
        }
        public bool HasOrder(string indexValue)
        {
            return _orderIdIndex.ContainsKey(indexValue);
        }

        public IOrderData GetOrder(string inpItemId, SystemTypes.SourceSystemType inpSystemType)
        {
            string indexValue = inpSystemType.ToString() + inpItemId;
            return GetOrder(indexValue);
        }
        public IOrderData GetOrder(string inpItemId, ProductProperties.IdType inpIdType)
        {
            string indexValue = inpIdType.ToString() + inpItemId;
            return GetOrder(indexValue);
        }
        public IOrderData GetOrder(string indexValue)
        {
            if (_orderIdIndex.TryGetValue(indexValue, out int indexSequence))
            {
                IOrderData inventryItem = _ordersList[indexSequence];
                return inventryItem;
            }
            else
            {
                throw new KeyNotFoundException($"No Order for ID: {indexValue}");
            }
        }
    }
}
