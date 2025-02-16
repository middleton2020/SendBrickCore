using CM.SendBrick.Interfaces.Tools;
using CM.SendBrickCore.Interfaces.Messages;
using CM.SendBrickCore.Interfaces.Tools;

namespace CM.SendBrickCore.Interfaces
{
    /// <summary>
    /// Get configuration details.
    /// </summary>
    public interface ISetControlTools
    {
        IConfigurationFile GetConfigFile();
        IConnectionParameters GetConnectionParamsController();
        IErrors GetErrorHandler();
        ILogging GetLogHandler();
        IMessageData GetMessageHandler();
    }
}
