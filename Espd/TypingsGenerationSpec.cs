using System;
using System.Collections.Generic;
using System.Text;
using TypeGen.Core.SpecGeneration;

namespace Hilma.Espd.EDM
{
  public class TypingsGenerationSpec : GenerationSpec
  { 
    
    public TypingsGenerationSpec()
    {
      AddClass<QualificationApplicationRequest>();
    }

    public override void OnBeforeBarrelGeneration(OnBeforeBarrelGenerationArgs args)
    {
      AddBarrel(".", BarrelScope.Files);
      AddBarrel(".");
    }
  }

}
