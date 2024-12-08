namespace TodoList.Domain.Classes.Validation.Strings;

internal readonly record struct InvalidString(string Value, IEnumerable<string> ValidationErrors);
