namespace CM.SendBrickCore.Interfaces.Connectors
{
    /// <summary>
    /// Connect to syste APIs using various protocols.
    /// </summary>
    public interface IApiConnect
    {
        string RunReadCommandOnAPI(string actionrequest);
        string RunReadCommandOnAPI(string actionrequest, string parameters);
        string RunUpdateCommandOnAPI(string inpActionRequest);
        string RunUpdateCommandOnAPI(string inpActionRequest, string inpParameters);
    }
}
