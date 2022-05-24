using System;

namespace MangaLibCollection.Model.Enums
{
    [Flags]
    public enum PublishingStatus
    {
        Publishing = 0b_0000_0000,
        Finished = 0b_0000_0001,
        OnHiatus = 0b_0000_0010,
        Unknown = 0b_0000_0011
    }
}
