using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CM.SendBrickCore.Interfaces.FunctionModules;

namespace CM.SendBrickCore.FunctionModules.Orders
{
    public class OrderParcelData : IOrderParcelData
    {
        #region Variables
        private int parcelInstance = 0;
        private string parcelId = "";
        private double parcelWeight = 0;
        private int parcelLength = 0;
        private int parcelWidth = 0;
        private int parcelHeight = 0;
        #endregion

        #region Properties
        public int ParcelInstance
        {
            get
            {
                return this.parcelInstance;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException($"'{nameof(this.ParcelInstance)}' cannot be zero.", "ParcelInstance");
                }
                else
                {
                    this.parcelInstance = value;
                }
            }
        }
        public string ParcelId
        {
            get
            {
                return this.parcelId;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.ParcelId)}' cannot be null.", "ParcelId");
                }
                else
                {
                    this.parcelId = value;
                }
            }
        }
        public double ParcelWeight
        {
            get
            {
                return this.parcelWeight;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException($"'{nameof(this.ParcelWeight)}' cannot be zero.", "ParcelWeight");
                }
                else
                {
                    this.parcelWeight = value;
                }
            }
        }
        public int ParcelLength
        {
            get
            {
                return this.parcelLength;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException($"'{nameof(this.ParcelLength)}' cannot be zero.", "ParcelLength");
                }
                else
                {
                    this.parcelLength = value;
                }
            }
        }
        public int ParcelWidth
        {
            get
            {
                return this.parcelWidth;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException($"'{nameof(this.ParcelWidth)}' cannot be zero.", "ParcelWidth");
                }
                else
                {
                    this.parcelWidth = value;
                }
            }
        }
        public int ParcelHeight
        {
            get
            {
                return this.parcelHeight;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException($"'{nameof(this.ParcelHeight)}' cannot be zero.", "ParcelHeight");
                }
                else
                {
                    this.parcelHeight = value;
                }
            }
        }
        #endregion

        #region Constructors
        public OrderParcelData()
        {
            this.parcelInstance = 0;
            this.parcelId = "";
        }
        public OrderParcelData(int inpParcelInstance,
                       string inpParcelId) : this()
        {
            this.ParcelInstance = inpParcelInstance;
            this.ParcelId = inpParcelId;
        }
        public OrderParcelData(int inpParcelInstance,
                       string inpParcelId,
                       double inpParcelWeight) : this(inpParcelInstance, inpParcelId)
        {
            this.ParcelWeight = inpParcelWeight;
        }
        public OrderParcelData(int inpParcelInstance,
                       string inpParcelId,
                       double inpParcelWeight,
                       int inpParcelLength,
                       int inpParcelWidth,
                       int inpParcelHeight) : this(inpParcelInstance, inpParcelId, inpParcelWeight)
        {
            this.ParcelLength = inpParcelLength;
            this.ParcelWidth = inpParcelWidth;
            this.ParcelHeight = inpParcelHeight;
        }
        #endregion
    }
}
