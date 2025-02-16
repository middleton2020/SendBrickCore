namespace CM.SendbrickShared.Enums
{
    /// <summary>
    /// Properties for the items.
    /// </summary>
    public class ProductProperties
    {
        public enum IdType
        {
            Unset,
            BoId,           // inventory_id
            BrickLinkId,    // used by BrickLink
            BrickOwlId,     // used by BrickOwl
            ExternalId,
            LegoId,
            LotId,          // bind_id
            LocalId         // used by local system
        }
        public enum Condition
        {
            NoUpdate,
            New,            // new_or_used = "N": New, completeness = "C": Complete
            NewSealed,      // new_or_used = "N": New, completeness = "S": Sealed
            NewComplete,    // new_or_used = "N": New, completeness = "C": Complete
            NewIncomplete,  // new_or_used = "N": New, completeness = "B": Incomplete
            UsedComplete,   // new_or_used = "U": Used, completeness = "C": Complete
            UsedIncomplete, // new_or_used = "U": Used, completeness = "B": Incomplete
            UsedLikeNew,    // new_or_used = "U": Used, completeness = "C": Complete
            UsedGood,       // new_or_used = "U": Used, completeness = "C": Complete
            UsedAcceptable, // new_or_used = "U": Used, completeness = "C": Complete
            Other           // new_or_used = "U": Used, completeness = "B": Incomplete
        }
        public enum Category
        {
            Gear,
            Instructions,
            Minibuild,
            Minifigure,
            Packaging,
            Part,
            Sticker,
            Unknown
        }
    }
}
