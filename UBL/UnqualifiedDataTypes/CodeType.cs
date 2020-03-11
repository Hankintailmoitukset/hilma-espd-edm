using System;
using System.ComponentModel.DataAnnotations;

namespace UBL.UnqualifiedDataTypes
{
  /// <summary>
  /// Typed CodeType for enums
  /// </summary>
  /// <typeparam name="TListEnum"></typeparam>
  public class CodeType<TListEnum> : CodeType where TListEnum : struct
  {
    private TListEnum ListValue { get; set; }

    public override string Value
    {
      get => ListValue.ToString();
      set
      {
        if (Enum.TryParse(value, true, out TListEnum listValue))
        {
          ListValue = listValue;
        }

        throw new ArgumentOutOfRangeException($"Not valid argument for {typeof(TListEnum)}");
      }
    }


  }

  /// <summary>
  /// A character string (letters, figures, or symbols) that for brevity and/or language
  /// independence may be used to represent or replace a definitive value or text of an
  /// attribute together with relevant supplementary information.
  /// </summary>
  public class CodeType : IListValueType, ILocalizableType
  {
    /// <summary>
    /// The identification of a list of codes.
    /// </summary>
    public string? ListID { get; set; }

    /// <summary>
    /// The name of a list of codes.
    /// </summary>
    public string? ListName { get; set; }
    /// <summary>
    /// An agency that maintains one or more lists of codes.
    /// </summary>
    /// <remarks>Defaults to the UN/EDIFACT data element 3055 code list.</remarks>
    public string? ListAgencyID { get; set; }

    /// <summary>
    /// The name of the agency that maintains the list of codes.
    /// </summary>
    public string? ListAgencyName { get; set; }

    /// <summary>
    /// The version of the list of codes.
    /// </summary>
    public string? ListVersionID { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Uri? ListURI { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Uri? ListSchemeURI { get; set; }

    /// <summary>
    /// The textual equivalent of the code content component.
    /// </summary>
    public string? Name { get; set; }


    /// <summary>
    /// The identifier of the language used in the code name.
    /// </summary>
    [RegularExpression("([a-zA-Z]{2}|[iI]-[a-zA-Z]+|[xX]-[a-zA-Z]{1,8})(-[a-zA-Z]{1,8})*")]
    public string? LanguageID { get; set; }

    public CodeType()
    {
    }

    public CodeType(string value)
    {
      Value = value;
    }

    /// <summary>
    /// The value of the code
    /// </summary>
    public virtual string Value { get; set; }

    public static implicit operator string(CodeType c) => c.Value;

    public static implicit operator CodeType(string s) => new CodeType(s);

  }
}
