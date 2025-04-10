using CM.SendBrickCore.Interfaces.FunctionModules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrickCore.ConnectModules.BrickOwl
{
    //Was BricklinkOrderCommands
    public class BrickOwlOrderApiTools : IOrderCommands
    {
        #region Invoices
        public string GetInvoiceTransactions(string inpInvoiceId, string inpIdType)
        {
            string returnJson = "";

            return returnJson;
        }
        #endregion

        #region Orders
        public string GetOrderList(string inpStatus, string inpOrderTime, int inpRecordLimit, string inpListType)
        {
            string returnJson = "";

            // This runs the above method, passing the output to a varible.
            //            var result = BrickOwlConnect.ConnectToAPI();

            return returnJson;
        }
        public string GetOrderView(string inpOrderId)
        {
            string returnJson = "";

            return returnJson;
        }
        public string GetOrderItems(string inpOrderId)
        {
            string returnJson = "";

            return returnJson;
        }
        public string SetOrderTracking(string inpOrderId, string inpTrackingId)
        {
            string returnJson = "";

            return returnJson;
        }
        public string SetOrderNote(string inpOrderId, string inpNote)
        {
            string returnJson = "";

            return returnJson;
        }
        public string GetOrderTaxSchemes()
        {
            string returnJson = "";

            return returnJson;
        }
        public string SetOrderNotify(string inpIpAddress)
        {
            string returnJson = "";

            return returnJson;
        }
        public string SetOrderFeedback(string inpOrderId, string inpComment, int inpRating)
        {
            string returnJson = "";

            return returnJson;
        }
        public string SetOrderStatus(string inpOrderId, string inpStatusId)
        {
            string returnJson = "";

            return returnJson;
        }
        #endregion

        #region User
        //public string GetUserToken(string inpUsername, string inpAppName)
        //{
        //        string returnJson = "";

        //        return returnJson;
        //}
        //public string GetUserDetails()
        //{
        //        string returnJson = "";

        //        return returnJson;
        //}
        //public string GetUserAddress()
        //{
        //        string returnJson = "";

        //        return returnJson;
        //}
        #endregion

        #region Wishlist
        //public string GetWishlists()
        //{
        //        string returnJson = "";

        //        return returnJson;
        //}
        //public string GetWishlistsLots(string inpWishlistId)
        //{
        //        string returnJson = "";

        //        return returnJson;
        //}
        //public string SetWishlistLots(string inpWishlistId, string inpLotId, int inpMinQuantity, decimal inpMaxPrice, string inpNote, string inpMinCondition)
        //{
        //        string returnJson = "";

        //        return returnJson;
        //}
        //public string SetWishlistDelete(string inpWishlistId, string inpLotId)
        //{
        //        string returnJson = "";

        //        return returnJson;
        //}
        //public string SetWishlistCreateList(string inpName, string inpDescription)
        //{
        //        string returnJson = "";

        //        return returnJson;
        //}
        //public string SetWishlistUpdateList(string inpWishlisstId, string inpName)
        //{
        //        string returnJson = "";

        //        return returnJson;
        //}
        //public string SetWishlistDeleteList(string inpWishlisstId)
        //{
        //        string returnJson = "";

        //        return returnJson;
        //}
        //public string SetWishlistAddLot(string inpWishlisstId, string inpBoId, string inpColorId)
        //{
        //        string returnJson = "";

        //        return returnJson;
        //}
        #endregion
    }
}
