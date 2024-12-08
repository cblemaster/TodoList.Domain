
namespace TodoList.Domain.Primitives;

internal readonly record struct Descriptor(ValidString Value, int MaxLength, bool IsRequired, bool IsAllowAllWhitespace);
