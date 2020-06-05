using Hilma.Espd.EDM.CriterionModels;
using Hilma.Espd.EDM.CriterionModels.v2_1_0;
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
