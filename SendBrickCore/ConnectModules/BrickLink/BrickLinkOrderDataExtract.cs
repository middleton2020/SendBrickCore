using CM.JsonTools;
using CM.SendBrickCore.FunctionModules.Orders;
using CM.SendbrickShared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrickCore.ConnectModules.BrickLink
{
    // Was BrickLinkOrderReader
    public class BrickLinkOrderDataExtract
    {
        private OrderManager orderManager = null;
        private OrderData order = null;
        private int currentOrder = 0;

        #region JsonToolsVariables
        private JsonReader jsonReader;
        private JsonReader.DeligateMakeObject makeObject;
        private JsonReader.DeligateCloseObject closeObject;
        private JsonReader.DeligateMakeArray makeArray;
        private JsonReader.DeligateCloseArray closeArray;
        private JsonReader.DeligateSetBoolean setBoolean;
        private JsonReader.DeligateSetDecimal setDecimal;
        private JsonReader.DeligateSetInteger setInteger;
        private JsonReader.DeligateSetString setString;
        #endregion

        #region Constructors
        public BrickLinkOrderDataExtract()
        {
            // Setup the JSON handling tools.
            makeObject = MakeObject;
            closeObject = CloseObject;
            makeArray = MakeArray;
            closeArray = CloseArray;
            setBoolean = SetField;
            setDecimal = SetField;
            setInteger = SetField;
            setString = SetField;

            jsonReader = new JsonReader(makeObject,
                                        closeObject,
                                        makeArray,
                                        closeArray,
                                        setBoolean,
                                        setDecimal,
                                        setInteger,
                                        setString);

            // If we've not been passed an OrderManager, then we need to create one.
            if (orderManager == null)
            {
                orderManager = new OrderManager();
            }
        }
        public BrickLinkOrderDataExtract(OrderManager inpManager) : this()
        {
            orderManager = inpManager;
        }
        #endregion // Constructors

        #region OrderUnpackingDeligates
        public object MakeObject(string inpName, object inpOrder, string inpPath)
        {
            if (inpName == "" || inpName == "Root")
            {
                order = new OrderData();
                currentOrder = orderManager.AddOrder(order);
                order.SourceSystem = SystemTypes.SourceSystemType.BrickLink;
                inpOrder = order;
            }
            else if (inpName == "payment")
            {
                orderManager.GetOrder(currentOrder);
            }
            else if (inpName == "shipping")
            {
                orderManager.GetOrder(currentOrder);
            }
            //else if (inpName == "shipping")
            //{

            //}
            else if (inpName == "address")
            {
                orderManager.GetOrder(currentOrder);
            }
            else if (inpName == "name")
            {
                orderManager.GetOrder(currentOrder);
            }
            else if (inpName == "cost")
            {
                orderManager.GetOrder(currentOrder);
            }
            else if (inpName == "disp_cost")
            {
                orderManager.GetOrder(currentOrder);
            }
            else if (inpName == "external_lot_ids")
            {

            }
            else if (inpName == "ids")
            {

            }

            return inpOrder;
        }
        public object CloseObject(string inpName, object inpOrder, string inpPath)
        {
            return inpOrder;
        }
        public object MakeArray(string inpName, object inpOrder, string inpPath)
        {
            if (inpName == "" || inpName == "Root")
            {

            }
            else if (inpName == "ids")
            {

            }

            return inpOrder;
        }
        public object CloseArray(string inpName, object inpOrder, string inpPath)
        {
            switch (inpName)
            {
            }

            return inpOrder;
        }
        public object SetField(string inpName, bool inpValue, object inpOrder, string inpPath)
        {
            switch (inpName)
            {
            }

            return inpOrder;
        }
        public object SetField(string inpName, decimal inpValue, object inpOrder, string inpPath)
        {
            switch (inpName)
            {
            }

            return inpOrder;
        }
        public object SetField(string inpName, int inpValue, object inpOrder, string inpPath)
        {
            switch (inpName)
            {
                case "order_id":
                    order.SupplierReference1 = inpValue.ToString();
                    break;
            }

            return inpOrder;
        }
        public object SetField(string inpName, string inpValue, object inpOrder, string inpPath)
        {
            switch (inpName)
            {
                case "date_ordered":
                    order.PostingDate = Convert.ToDateTime(inpValue);
                    break;
                case "seller_name":
                    order.SupplierContactName = inpValue;
                    break;
                case "store_name":
                    order.SupplierBusinessName = inpValue;
                    break;
                case "buyer_name":
                    order.CustomerContactName = inpValue;
                    break;
                case "buyer_email":
                    order.CustomerEmailAddress = inpValue;
                    break;
                case "currency_code":
                    order.CustomsCurrency = inpValue; break;
            }

            return inpOrder;
        }
        #endregion  // OrderUnpackingDeligates
    }
}
