namespace CM.SendbrickShared.Enums
{
    /// <summary>
    /// Systems that we can connect to.
    /// </summary>
    public class SystemTypes
    {
        // All the systems that can send Orders through this system.
        public enum SourceSystemType
        {
            BrickLink,
            BrickOwl,
            Local,
            Unset
        }

        // All the systems that can be used to Post Orders through this system.
        public enum PostageSystemType
        {
            DPD,
            Evri,
            RoyalMail,
            UPS,
            Unset
        }
    }
}
