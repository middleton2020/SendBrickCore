using CM.SendBrickCore.Connectors;
using CM.SendBrickCore.Core;
using CM.SendBrickCore.Interfaces.FunctionModules;
using CM.SendBrickCore.Interfaces.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrickCore.ConnectModules.BrickLink
{
    public class BrickLinkOrderApiTools : IOrderCommands
    {
        #region Variables
        OAuth1Connect connectionControl;
        #endregion

        #region Constructors
        public BrickLinkOrderApiTools(SetControlTools inpControlTools)
        {
            connectionControl = new OAuth1Connect(inpControlTools);
        }
        public BrickLinkOrderApiTools(IConnectionParameters inpConnectionParams)
        {
            connectionControl = new OAuth1Connect(inpConnectionParams);
        }
        public BrickLinkOrderApiTools(IConfigurationFile inpConfigFile)
        {
            connectionControl = new OAuth1Connect(inpConfigFile);
        }
        #endregion

        #region Orders
        public string GetOrderList(string inpStatus, string inpOrderTime, int inpRecordLimit, string inpListType)
        {
            string returnJson = "";

            var result = connectionControl.RunReadCommandOnAPI("orders");
            // var result = BrickOwlConnect.ConnectToAPI(inpApiKey, "orders", parametersToAdd).Result;

            returnJson = result;

            return returnJson;
        }
        public string GetOrderDetails(string inpOrderId)
        {
            string returnJson = "";

            return returnJson;
        }
        public string GetOrderItems(string inpOrderId)
        {
            string returnJson = "";

            return returnJson;
        }
        public string GetOrderMessages()
        {
            return "";
        }
        public string GetOrderFeedback()
        {
            return "";
        }

        public string SetOrderUpdate()
        {
            return "";
        }
        public string SetOrderTracking(string inpOrderId, string inpTrackingId)
        {
            return "";
        }
        public string SetOrderStatus(string inpOrderId, string inpStatusId)
        {
            return "";
        }
        public string SetOrderFeedback(string inpOrderId, string inpComment, int inpRating)
        {
            string returnJson = "";

            return returnJson;
        }
        public string ReplyOrderFeedback(string inpOrderId, string inpComment, int inpRating)
        {
            string returnJson = "";

            return returnJson;
        }

        public string GetInvoiceTransactions(string inpInvoiceId, string inpIdType)
        {
            throw new NotImplementedException();
        }

        public string GetOrderTaxSchemes()
        {
            throw new NotImplementedException();
        }

        public string GetOrderView(string inpOrderId)
        {
            throw new NotImplementedException();
        }

        public string SetOrderNote(string inpOrderId, string inpNote)
        {
            throw new NotImplementedException();
        }

        public string SetOrderNotify(string inpIpAddress)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
