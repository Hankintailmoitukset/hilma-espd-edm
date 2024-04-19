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

    string GenerateProperties(Property prop) {
        var propType = prop.Type;
        var propTypeName = propType.Name;
        string propName = prop.name;
        bool isRequired = prop.Attributes.Any(x => x.Name == "Required");

        return $"\n  public {propName}{(isRequired ? "!" : "?")}: {propTypeName}";
    }
    
    string GenerateRequiredInterfaceProperties(Property prop) {
        bool isRequired = prop.Attributes.Any(x => x.Name == "Required");

        if (!isRequired) {
            return string.Empty;
        }

        var propType = prop.Type;
        var propTypeName = propType.Name;
        string propName = prop.name;

        return $"\n  {propName}: {propTypeName}";
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
}$Classes([Contract])[$Name[$RegisterTypeName]$Properties[$Type[$ImportType]]import assign from 'lodash.assign'

interface RequiredArgs$Name {$Properties[$GenerateRequiredInterfaceProperties]
}

export class $Name {
  public constructor(init?:Partial<$Name> & RequiredArgs$Name) {
    assign(this, init)
  }$BaseClass[$Properties[$GenerateProperties]
  ]$Properties[$GenerateProperties]
  ]
}$Name[$Clear]
