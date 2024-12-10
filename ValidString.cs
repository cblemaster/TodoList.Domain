
namespace TodoList.Domain;

internal record ValidString(string Value) : ValidatableString(Value);
