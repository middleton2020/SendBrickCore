namespace CM.SendBrickCore.Interfaces.Connectors
{
    /// <summary>
    /// Connect to syste APIs using various protocols.
    /// </summary>
    public interface IApiConnect
    {
        string RunReadCommandOnAPI(string inpActionRequest);
        string RunReadCommandOnAPI(string inpActionRequest, string inpParameters);
        string RunUpdateCommandOnAPI(string inpActionRequest);
        string RunUpdateCommandOnAPI(string inpActionRequest, string inpParameters);
    }
}
