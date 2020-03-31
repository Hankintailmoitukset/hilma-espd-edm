using System;

namespace Hilma.UBL.Attributes
{
    /// <summary>
    /// Data contract attribute to signal generation of Typescript typings
    /// </summary>
    [AttributeUsage(AttributeTargets.Class |  
                           AttributeTargets.Struct | 
                           AttributeTargets.Enum ) ] 
    public class ContractAttribute : Attribute {

    }
}
