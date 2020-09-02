${
    using Typewriter.Extensions.Types;

    static List<string> ImportedTypes = new List<string>();
    
    string LoudName(Property property)
    { 
        return property.Name.ToUpperInvariant();
    }
    
    void RegisterTypeName( string name ) {
    
        ImportedTypes.Add( name );
    }
    
    string ConvertDefault(Type type) {
        if (type.IsEnumerable) {
            return "= []";
        }

        if(type.IsGuid) {
            return "= '00000000-0000-0000-0000-000000000000'";  
        }

        if (type.ClassName() == nameof(String).ToLowerInvariant()) {
            return "= ''";
        }

        if (type.Name == nameof(Boolean).ToLowerInvariant()) {
            return "= false";
        }

        if (type.IsNullable) {
            return "| null = null";
        }

        if (type.ClassName() == "number") {
            return "= 0";
        }

        if (type.Attributes.Any(x => x.Name == "Contract")) {
            return $"= new {type.Name}()";
        }

        if (type.Attributes.Any(x => x.Name == "EnumContract")) {
            return $"= 0";
        }
          
        return "| undefined";
    }

    string ImportType(Type type) {
        if (type.Attributes.Any(x => x.Name == "Contract" || x.Name == "EnumContract")) {
            if (!ImportedTypes.Contains(type.Name)) {
                ImportedTypes.Add(type.Name);
                return $"import {'{'} {type.Name} {'}'} from './{type.Name}'\n";
            }
        }

        // handle generics
        var foundTypes = type.TypeArguments.Where(y => y.Attributes.Any(x => x.Name == "Contract" || x.Name == "EnumContract"));
        foreach (var foundType in foundTypes) {
            if (!ImportedTypes.Contains(foundType.Name)) {
                ImportedTypes.Add(foundType.Name);
                return $"import {'{'} {foundType.Name} {'}'} from './{foundType.Name}'\n";
            }
        }

        return string.Empty;
    }

    string Clear(string dummy) {
        ImportedTypes.Clear();
        return string.Empty;
    }
}
$Classes([Contract])[
$Name[$RegisterTypeName]
$Properties[$Type[$ImportType]]
import assign from 'lodash.assign'

export class $Name { 
    public constructor(init?:Partial<$Name>) {
        assign(this, init)
    } 
    $BaseClass[$Properties[
    $name?: $Type]]
    $Properties[
    $name?: $Type]
}$Name[$Clear]]