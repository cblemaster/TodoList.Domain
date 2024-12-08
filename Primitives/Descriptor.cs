
namespace TodoList.Domain.Primitives;

internal record Descriptor(ValidString Value, int MaxLength, bool IsRequired, bool IsAllowAllWhitespace);
