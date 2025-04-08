using CM.SendBrickCore.Interfaces;
using CM.SendBrickCore.Interfaces.Connectors;
using CM.SendBrickCore.Interfaces.Tools;
using CM.SendbrickShared.Enums;

namespace CM.SendBrickCore.Connectors
{
    public class ApiConnectController
    {
        #region Variables
        private Dictionary<string, IApiConnect> systemApiList = new Dictionary<string, IApiConnect>();
        IConfigurationFile fileConfigurationFile = null;
        IConnectionParameters connectionParameters = null;
        #endregion  // Variables

        #region Constructors

        public ApiConnectController(IConnectionParameters inpConnectionParameters)
        {
            connectionParameters = inpConnectionParameters;
        }
        /// <summary>
        /// Constructor, sets up the control classes we're using.
        /// </summary>
        /// <param name="inpSetControlTools">The Control Tools Object holding our config.</param>
        public ApiConnectController(ISetControlTools inpSetControlTools)
        {
            fileConfigurationFile = inpSetControlTools.GetConfigFile();
        }
        /// <summary>
        /// Constructor, sets up the control classes we're using.
        /// </summary>
        /// <param name="inpConfigFile">The config file object to use.</param>
        public ApiConnectController(IConfigurationFile inpConfigFile)
        {
            fileConfigurationFile = inpConfigFile;
        }
        #endregion  // Constructors

        #region APIConnectors
        public IApiConnect GetApiConnect(SystemTypes.PostageSystemType inpSystem)
        {
            return GetApiConnect(inpSystem.ToString());
        }
        public IApiConnect GetApiConnect(SystemTypes.SourceSystemType inpSystem)
        {
            return GetApiConnect(inpSystem.ToString());
        }
        private IApiConnect GetApiConnect(string inpSystem)
        {
            IApiConnect systemAPI = null;

            if (systemApiList.ContainsKey(inpSystem))
            {
                systemAPI = systemApiList[inpSystem];
            }
            else
            {
                string systemType = connectionParameters.GetConnectionParameter(inpSystem, "apitype");
                switch (systemType.ToLower())
                {
                    case "oauth1":
                        systemAPI = new OAuth1Connect(connectionParameters);
                        break;
                    //case "oauth2":
                    //    break;
                    case "publickey":
                        systemAPI = new PublicKeyConnect(connectionParameters);
                        break;
                }
                systemApiList.Add(inpSystem, systemAPI);
            }

            return systemAPI;
        }
        #endregion  // APIConnectors
    }
}
