using System;

namespace MLC.Model.Enums
{
    [Flags]
    public enum CollectionStatus
    {
        NotCollecting = 0b_0000_0000,
        BeganCollecting = 0b_0000_0001,
        Collecting = 0b_0000_0010,
        FinishedCollecting = 0b_0000_0011
    }
}
