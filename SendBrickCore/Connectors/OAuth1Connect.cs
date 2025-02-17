using CM.SendBrickCore.Interfaces;
using CM.SendBrickCore.Interfaces.Connectors;
using CM.SendBrickCore.Interfaces.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrickCore.Connectors
{
    /// <summary>
    /// Connect to systems using oAuth1 protocols.
    /// </summary>
    public class OAuth1Connect : IAPIConnect
    {
        #region Variables
        // Validate that these only contain hexidecimal values.
        private string consumerKey;
        private string tokenValue;
        private string consumerSecret;
        private string tokenSecret;
        private string baseUrl;
        #endregion;

        #region Constructors
        /// <summary>
        /// Setup the connection parameters.
        /// </summary>
        /// <param name="inpControlTools">Control tool which will return the connection parameters.</param>
        public OAuth1Connect(ISetControlTools inpControlTools)
        {
            IConnectionParameters connectionParams = inpControlTools.GetConnectionParamsController();
            SetConnectionParameters(connectionParams);
        }

        #endregion  // Constructors

        #region ConstructorMethods
        /// <summary>
        /// Setup the connection parameters now that we have the control object available.
        /// </summary>
        /// <param name="inpConnectionParams">The control object to provide the connection parameters.</param>
        private void SetConnectionParameters(IConnectionParameters inpConnectionParams)
        {
            SystemTypes.SourceSystemType system = SystemTypes.SourceSystemType.BrickLink;
            consumerKey = inpConnectionParams.GetConnectionParameter(system, "consumerkey");
            tokenValue = inpConnectionParams.GetConnectionParameter(system, "tokenvalue");
            consumerSecret = inpConnectionParams.GetConnectionParameter(system, "consumerssecret");
            tokenSecret = inpConnectionParams.GetConnectionParameter(system, "tokenSecret");
            baseUrl = inpConnectionParams.GetConnectionParameter(system, "url");
        }
        #endregion


        public string RunReadCommandOnAPI(string actionrequest)
        {
            throw new NotImplementedException();
        }

        public string RunReadCommandOnAPI(string actionrequest, string parameters)
        {
            throw new NotImplementedException();
        }

        public string RunUpdateCommandOnAPI(string inpActionRequest)
        {
            throw new NotImplementedException();
        }

        public string RunUpdateCommandOnAPI(string inpActionRequest, string inpParameters)
        {
            throw new NotImplementedException();
        }
    }
}
