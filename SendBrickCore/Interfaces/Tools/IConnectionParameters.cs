using CM.SendbrickShared.Enums;

namespace CM.SendBrickCore.Interfaces.Tools
{
    public interface IConnectionParameters
    {
        string GetConnectionParameter(SystemTypes.PostageSystemType inpSystem, string inpParameterName);
        string GetConnectionParameter(SystemTypes.SourceSystemType inpSystem, string inpParameterName);
        string GetConnectionParameter(string inpSystem, string inpParameterName);

        string[] GetSystemList();
        string[] ReGetSystemList();
        bool IsValidSystem(string inpSystem);
        bool IsValidSystem(SystemTypes.PostageSystemType inpSystem);
        bool IsValidSystem(SystemTypes.SourceSystemType inpSystem);
    }
}
