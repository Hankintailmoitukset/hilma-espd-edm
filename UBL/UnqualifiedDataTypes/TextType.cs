﻿using UBL.PrimitiveTypes;

namespace UBL.UnqualifiedDataTypes
{
  /// <summary>
  /// A character string (i.e. a finite set of characters) generally in the form of words of a language.
  /// </summary>
  public class TextType : StringType
  {
    public TextType()
    {
    }

    public TextType(string value)
    {
      Value = value;
    }

    public static implicit operator string(TextType t) => t?.Value;

    public static implicit operator TextType(string t) => new TextType(t);

  }
}