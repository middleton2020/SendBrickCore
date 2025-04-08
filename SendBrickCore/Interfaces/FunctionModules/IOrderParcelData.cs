namespace CM.SendBrickCore.Interfaces.FunctionModules
{
    public interface IOrderParcelData
    {
        int ParcelHeight { get; set; }
        string ParcelId { get; set; }
        int ParcelInstance { get; set; }
        int ParcelLength { get; set; }
        double ParcelWeight { get; set; }
        int ParcelWidth { get; set; }
    }
}