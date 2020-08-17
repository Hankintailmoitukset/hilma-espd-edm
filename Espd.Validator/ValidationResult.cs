using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Espd.Validator
{
  public class ValidationResult
  {
    public ValidationResult(bool isSuccess, IEnumerable<string> errors)
    {
      IsSuccess = isSuccess;
      Errors = errors.ToArray();
    }

    public bool IsSuccess { get; private set; }

    public string[] Errors { get; }
  }

}
