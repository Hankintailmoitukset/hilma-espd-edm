﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using Hilma.Espd.EDM.Serializers;

namespace Espd.Validator
{
  public class EspdXmlValidator
  {
    private const string QualificationApplicationRequestXsd =
      "UBL-QualificationApplicationRequest-2.2.xsd";
    private const string QualificationApplicationResponseXsd =
      "UBL-QualificationApplicationResponse-2.2.xsd";

    public ValidationResult ValidateQualificationApplicationRequest(XDocument espdDocument)
    {
      if (espdDocument == null)
      {
        throw new ArgumentNullException(nameof(espdDocument));
      }

      var path = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
      var schema = new XmlSchemaSet { XmlResolver = new XmlUrlResolver() };
      var nameSpace = EspdNames.Qarq;
      schema.Add(nameSpace.ToString(), Path.Combine(path, "Schemas", "2.1.1", "maindoc", QualificationApplicationRequestXsd));
      schema.Compile();
      
      var validationErrors = new List<string>();

      if (espdDocument.Root == null)
      {
        validationErrors.Add("Root element is null");
      }
      else if (!espdDocument.Root.Name.Namespace.Equals(EspdNames.Qarq))
      {
        validationErrors.Add("Root element namespace is wrong or empty:" + espdDocument.Root.Name.Namespace );
      }

      espdDocument.Validate(schema, (sender, e) => { validationErrors.Add(e.Message); });

      return new ValidationResult(!validationErrors.Any(), validationErrors);

    }

    public ValidationResult ValidateQualificationApplicationResponse(XDocument espdResponseDocument)
    {
      if (espdResponseDocument == null)
      {
        throw new ArgumentNullException(nameof(espdResponseDocument));
      }

      var path = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
      var schema = new XmlSchemaSet { XmlResolver = new XmlUrlResolver() };
      var nameSpace = EspdNames.Qarp;
      schema.Add(nameSpace.ToString(), Path.Combine(path, "Schemas", "2.1.1", "maindoc", QualificationApplicationResponseXsd));
      schema.Compile();

      var validationErrors = new List<string>();

      if (espdResponseDocument.Root == null)
      {
        validationErrors.Add("Root element is null");
      }
      else if (!espdResponseDocument.Root.Name.Namespace.Equals(EspdNames.Qarp))
      {
        validationErrors.Add("Root element namespace is wrong or empty:" + espdResponseDocument.Root.Name.Namespace);
      }

      espdResponseDocument.Validate(schema, (sender, e) => { validationErrors.Add(e.Message); });

      return new ValidationResult(!validationErrors.Any(), validationErrors);
    }
  }
}