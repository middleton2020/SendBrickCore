using CM.SendBrick.Interfaces.Tools;
using CM.SendBrickCore.Interfaces.Connectors;
using CM.SendBrickCore.Interfaces.Tools;
using CM.SendBrickCore.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrickCore.Connectors
{
    public class PublicKeyConnect : IApiConnect
    {
        #region Variables
        IConnectionParameters connectionParameters = null;
        #endregion  // Variables

        #region Constructors
        public PublicKeyConnect(IConnectionParameters inpConnectionParameters)
        {
            connectionParameters = inpConnectionParameters;
        }
        #endregion  // Constructors

        string IApiConnect.RunReadCommandOnAPI(string actionrequest)
        {
            throw new NotImplementedException();
        }

        string IApiConnect.RunReadCommandOnAPI(string actionrequest, string parameters)
        {
            throw new NotImplementedException();
        }

        string IApiConnect.RunUpdateCommandOnAPI(string inpActionRequest)
        {
            throw new NotImplementedException();
        }

        string IApiConnect.RunUpdateCommandOnAPI(string inpActionRequest, string inpParameters)
        {
            throw new NotImplementedException();
        }
    }
}
