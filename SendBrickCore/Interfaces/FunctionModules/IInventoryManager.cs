using CM.SendbrickShared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrickCore.Interfaces.FunctionModules
{
    /// <summary>
    /// Store the collection of InventoryItemData records
    /// </summary>
    public interface IInventoryManager
    {
        int AddItem(IInventoryItemData inpItemData);
        IInventoryItemData GetItem(int Instance);
        IInventoryItemData GetItem(string indexValue);
        IInventoryItemData GetItem(string inpItemId, ProductProperties.IdType inpIdType);
        IInventoryItemData GetItem(string inpItemId, SystemTypes.SourceSystemType inpSystemType);
        bool HasItem(string indexValue);
        bool HasItem(string inpItemId, ProductProperties.IdType inpIdType);
        bool HasItem(string inpItemId, SystemTypes.SourceSystemType inpSystemType);
    }
}
