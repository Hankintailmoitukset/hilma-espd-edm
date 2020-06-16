using Hilma.UBL.Attributes;

namespace UBL.Enums
{
    [EnumContract]
    public enum ContractType : int
    {
        Any = 0,
        Supplies = 1,
        Services = 2,
        Works = 3
    }
}