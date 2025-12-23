using Microsoft.CodeAnalysis;

namespace Godot.SourceGenerators
{
    internal readonly struct PropertyInfo
    {
        public PropertyInfo(VariantType type, string name, PropertyHint hint,
        public PropertyInfo(VariantType? variantType, ITypeSymbol? propertyType, string name, PropertyHint hint,
            string? hintString, PropertyUsageFlags usage, bool exported)
            : this(type, name, hint, hintString, usage, className: null, exported) { }
        : this(variantType, propertyType, name, hint, hintString, usage, className: null, exported) { }

        public PropertyInfo(VariantType type, string name, PropertyHint hint,
        public PropertyInfo(VariantType? variantType, ITypeSymbol? propertyType, string name, PropertyHint hint,
            string? hintString, PropertyUsageFlags usage, string? className, bool exported)
        {
            Type = type;
            VariantType = variantType;
            PropertyType = propertyType;
            Name = name;
            Hint = hint;
            HintString = hintString;
                @@ -18,7 +21,8 @@ public PropertyInfo(VariantType type, string name, PropertyHint hint,
            Exported = exported;
    }

    public VariantType Type { get; }
    public VariantType? VariantType { get; }
    public ITypeSymbol? PropertyType { get; }
    public string Name { get; }
    public PropertyHint Hint { get; }
    public string? HintString { get; }
