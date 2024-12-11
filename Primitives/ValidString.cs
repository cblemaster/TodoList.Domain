namespace TodoList.Domain.Primitives;

internal record ValidString(string Value) : ValidatableString(Value);
