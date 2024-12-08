
namespace TodoList.Domain.Primitives;

internal class Descriptor
{
    internal required ValidString Value { get; init; }
    internal required int MaxLength { get; init; }
    internal required bool IsRequired { get; init; }
    internal required bool IsAllowAllWhitespace { get; init; }

    internal Descriptor(ValidString value, int maxLength, bool isRequired, bool isAllowAllWhitespace)
    {
        Value = value;
        MaxLength = maxLength;
        IsRequired = isRequired;
        IsAllowAllWhitespace = isAllowAllWhitespace;
    }
}
