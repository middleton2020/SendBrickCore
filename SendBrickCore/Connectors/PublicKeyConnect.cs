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

namespace CM.SendBrickCore.Connectors
{
    /// <summary>
    /// Connect to systems using a simple Public Key.
    /// </summary>
    public class PublicKeyConnect : IApiConnect
    {
        #region Variables
        private string apiKey;
        private string baseUrl;
        #endregion  // Variables

        #region Constructors
        public PublicKeyConnect(ISetControlTools inpControlTools)
        {
            IConnectionParameters connectionParams = inpControlTools.GetConnectionParamsController();

            apiKey = connectionParams.GetConnectionParameter(SystemTypes.SourceSystemType.BrickOwl, "apikey");
            baseUrl = connectionParams.GetConnectionParameter(SystemTypes.SourceSystemType.BrickOwl, "url");
        }
        public PublicKeyConnect(IConnectionParameters inpConnectionParams)
        {
            apiKey = inpConnectionParams.GetConnectionParameter(SystemTypes.SourceSystemType.BrickOwl, "apikey");
            baseUrl = inpConnectionParams.GetConnectionParameter(SystemTypes.SourceSystemType.BrickOwl, "url");
        }
        public PublicKeyConnect(IConfigurationFile inpConfigFile)
        {
            IConnectionParameters connectionParams = new ConnectionParameters(inpConfigFile);

            apiKey = connectionParams.GetConnectionParameter(SystemTypes.SourceSystemType.BrickOwl, "apikey");
            baseUrl = connectionParams.GetConnectionParameter(SystemTypes.SourceSystemType.BrickOwl, "url");
        }
        #endregion  // Constructors

        public string RunReadCommandOnAPI(string inpActionRequest)
        {
            return RunReadCommandOnAPI(inpActionRequest, "");
        }

        public string RunReadCommandOnAPI(string inpActionRequest, string inpParameters)
        {
            // This variable holds the call to brickowl.
            string url = baseUrl + "/"
                    + inpActionRequest
                    + "?key=" + apiKey
                    + inpParameters;

            var result = PublicKeyConnect.GetFromAPI(url).Result;
            return result;
        }

        public string RunUpdateCommandOnAPI(string inpActionRequest)
        {
            return RunUpdateCommandOnAPI(inpActionRequest, "");
        }

        public string RunUpdateCommandOnAPI(string inpActionRequest, string inpParameters)
        {
            // This variable holds the call to brickowl.
            string url = baseUrl + "/"
                    + inpActionRequest
                    + "?key=" + apiKey
                    + inpParameters;
            HttpContent body = null;

            var result = PublicKeyConnect.PutToAPI(url, body).Result;
            return result;
        }

        /// <summary>
        /// Call BrickOwl asynchronously to get the data for the instruction specified
        /// </summary>
        /// <param name="actionrequest">The command to pass to the API</param>
        /// <param name="parameters">Additional parameters that you want to add to the command.</param>
        /// <returns>JSON containg the details of the orders.</returns>
        public static async Task<string> GetFromAPI(string inpConnectionURL)
        {
            // Create an HTTP Client called client, through which we will run the above call.
            using (var client = new HttpClient())
            {
                // Set the url for the client.
                client.BaseAddress = new Uri(inpConnectionURL);

                // Check what comes back from the client.
                HttpResponseMessage response = await client.GetAsync(inpConnectionURL);

                if (response.IsSuccessStatusCode)
                {
                    // If the response was successful, then get the JSON response as a string.
                    string strResult = await response.Content.ReadAsStringAsync();

                    return strResult;
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                {
                    throw new HttpRequestException("Access to the specified module is forbidden: 403 error returned.");
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Call BrickOwl asynchronously to send the data for the instruction specified
        /// </summary>
        /// <param name="actionrequest">The command to pass to the API</param>
        /// <param name="parameters">Additional parameters that you want to add to the command.</param>
        /// <returns>JSON containg the details of the orders.</returns>
        public static async Task<string> PutToAPI(string inpConnectionURL, HttpContent inpContent)
        {
            // Create an HTTP Client called client, through which we will run the above call.
            using (var client = new HttpClient())
            {
                // Set the url for the client.
                client.BaseAddress = new Uri(inpConnectionURL);

                // Check what comes back from the client.
                HttpResponseMessage response = await client.PutAsync(inpConnectionURL, inpContent);

                if (response.IsSuccessStatusCode)
                {
                    // If the response was successful, then get the JSON response as a string.
                    string strResult = await response.Content.ReadAsStringAsync();

                    return strResult;
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                {
                    throw new HttpRequestException("Access to the specified module is forbidden: 403 error returned.");
                }
                else
                {
                    return null;
                }
            }
        }

    }
}
