using CM.SendBrick.Interfaces.Tools;
using CM.SendBrickCore.Interfaces;
using CM.SendBrickCore.Interfaces.Connectors;
using CM.SendBrickCore.Interfaces.Tools;
using CM.SendBrickCore.Tools;
using CM.SendbrickShared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// For using oAuth.
using RestSharp;    // To install this. In Command Line, navigate to the project directory. Then run 'dotnet add package RestSharp' or use NuGet.
using RestSharp.Authenticators;

namespace CM.SendBrickCore.Connectors
{
    /// <summary>
    /// Connect to systems using oAuth1 protocols.
    /// </summary>
    public class OAuth1Connect : IApiConnect
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
        /// <summary>
        /// Setup the connection parameters.
        /// </summary>
        /// <param name="inpConnectionParams">Connection parameters object which will return the connection parameters.</param>
        public OAuth1Connect(IConnectionParameters inpConnectionParams)
        {
            SetConnectionParameters(inpConnectionParams);
        }
        /// <summary>
        /// Setup the connection parameters.
        /// </summary>
        /// <param name="inpConfigFile">Configuration file to get the connection parameters from.</param>
        public OAuth1Connect(IConfigurationFile inpConfigFile)
        {
            IConnectionParameters connectionParams = new ConnectionParameters(inpConfigFile);
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

        #region PublicMethods
        /// <summary>
        /// Run the required process on the remote API.
        /// </summary>
        /// <param name="inpActionRequest">Action to run on the API</param>
        /// <returns></returns>
        public string RunReadCommandOnAPI(string inpActionRequest)
        {
            return RunReadCommandOnAPI(inpActionRequest, "");
        }
        /// <summary>
        /// Run the required process on the remote API.
        /// </summary>
        /// <param name="inpActionRequest">Action to run on the API</param>
        /// <param name="inpParameters">Parameters to pass to the API call</param>
        /// <returns></returns>
        public string RunReadCommandOnAPI(string inpActionRequest, string inpParameters)
        {
            var result = OAuth1Connect.ConnectToAPI(baseUrl, inpActionRequest, inpParameters, consumerKey, tokenValue, consumerSecret, tokenSecret);
            return result;
        }

        /// <summary>
        /// Run an update process on the remote API.
        /// </summary>
        /// <param name="inpActionRequest">Action to run on the API</param>
        /// <returns></returns>
        public string RunUpdateCommandOnAPI(string inpActionRequest)
        {
            return RunUpdateCommandOnAPI(inpActionRequest, "");
        }
        /// <summary>
        /// Run an update process on the remote API.
        /// </summary>
        /// <param name="inpActionRequest">Action to run on the API</param>
        /// <param name="inpParameters">Parameters to pass to the API call</param>
        /// <returns></returns>
        public string RunUpdateCommandOnAPI(string inpActionRequest, string inpParameters)
        {
            var result = OAuth1Connect.ConnectToAPI(baseUrl, inpActionRequest, inpParameters, consumerKey, tokenValue, consumerSecret, tokenSecret);
            return result;
        }
        #endregion

        #region PrivateMethods
        /// <summary>
        /// Connect to BrickLink and return the requested details.
        /// </summary>
        /// <returns>JSON holding the details of the orders in BrickLink.</returns>
        private static string ConnectToAPI(string inpBaseUrl, string inpActionrequest, string inpParameters, string inpConsumerKey, string inpTokenValue, string inpConsumerSecret, string inpTokenSecret)
        {
            // Create a RestClient with the base URL and an OAuth1 authenticator
            OAuth1Authenticator authenticator = OAuth1Authenticator.ForProtectedResource(inpConsumerKey, inpConsumerSecret, inpTokenValue, inpTokenSecret, RestSharp.Authenticators.OAuth.OAuthSignatureMethod.HmacSha1);
            RestClientOptions options = new RestClientOptions(inpBaseUrl)
            {
                Authenticator = authenticator
            };
            RestClient client = new RestClient(options);
            RestRequest request = new RestRequest(inpActionrequest, Method.Get);

            // Add the parameters to the request.
            AddParametersToCall(ref request, inpParameters);

            // Execute the request and get the response
            RestResponse response = client.Execute(request);

            if (response == null)
            {
                throw new ArgumentNullException(nameof(ConnectToAPI));
            }
            return response.Content;
        }
        /// <summary>
        /// Add parameters to the API call from the string.
        /// </summary>
        /// <param name="inpRequest">Request object to add the parameters to.</param>
        /// <param name="inpParameters">String containing the parameters to add as a semi-colon separate list of Name=Value</param>
        private static void AddParametersToCall(ref RestRequest inpRequest, string inpParameters)
        {
            if (string.IsNullOrWhiteSpace(inpParameters))
            { return; }

            string[] paramsArray = inpParameters.Split(';');
            foreach (string parameter in paramsArray)
            {
                string[] splitParameter = parameter.Split('=');
                if (splitParameter.Length > 1)
                {
                    string paramName = splitParameter[0];
                    string paramValue = splitParameter[1];
                    inpRequest.AddParameter(paramName, paramValue);
                }
            }
        }
        #endregion
    }
}
