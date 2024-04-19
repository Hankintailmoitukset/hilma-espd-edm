${
    using Typewriter.Extensions.Types;

    Template(Settings settings)
    {
        settings.OutputExtension = ".ts";
    }
}
$Enums([EnumContract])[export enum $Name {
  $Values[
  $Name = $Value][,]
}]
