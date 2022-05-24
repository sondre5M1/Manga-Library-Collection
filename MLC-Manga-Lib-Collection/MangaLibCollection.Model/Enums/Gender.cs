using System;

namespace MangaLibCollection.Model.Enums
{
    [Flags]
    public enum Gender
    {
        Male = 0b_0000_0000,
        Female = 0b_0000_0001,
        NotSpecified = Male | Female
    }
}
