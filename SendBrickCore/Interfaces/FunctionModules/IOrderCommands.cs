using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrickCore.Interfaces.FunctionModules
{
    public interface IOrderCommands
    {
        //string GetInvoiceTransactions(string inpInvoiceId, string inpIdType);
        string GetOrderItems(string inpOrderId);
        string GetOrderList(string inpStatus, string inpOrderTime, int inpRecordLimit, string inpListType);
        //string GetOrderTaxSchemes();
        string GetOrderView(string inpOrderId);
        string SetOrderFeedback(string inpOrderId, string inpComment, int inpRating);
        //string SetOrderNote(string inpOrderId, string inpNote);
        //string SetOrderNotify(string inpIpAddress);
        string SetOrderStatus(string inpOrderId, string inpStatusId);
        //string SetOrderTracking(string inpOrderId, string inpTrackingId);
    }
}
