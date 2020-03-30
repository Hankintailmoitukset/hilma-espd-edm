using System;

namespace Hilma.UBL.Attributes
{
    /// <summary>
    /// Data contract attribute to signal generation of Typescript typings
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Class |  
                           System.AttributeTargets.Struct | 
                           AttributeTargets.Enum ) ] 
    public class ContractAttribute : System.Attribute {

    }
}
