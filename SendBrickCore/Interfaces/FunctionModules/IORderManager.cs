using CM.SendbrickShared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrickCore.Interfaces.FunctionModules
{
    /// <summary>
    /// Store the collection of TransferOrderData records
    /// </summary>
    public interface IOrderManager
    {
        int AddOrder(IOrderData inpOrderData);
        IOrderData GetOrder(int inpInstance);
        IOrderData GetOrder(string indexValue);
        IOrderData GetOrder(string inpItemId, ProductProperties.IdType inpIdType);
        IOrderData GetOrder(string inpItemId, SystemTypes.SourceSystemType inpSystemType);
        bool HasOrder(string indexValue);
        bool HasOrder(string inpOrderId, ProductProperties.IdType inpIdType);
        bool HasOrder(string inpOrderId, SystemTypes.SourceSystemType inpSourceSystem);
    }
}
