namespace TodoList.Domain.ValueStructs;

internal readonly record struct ValidationResult(bool IsValid, IEnumerable<string> ValidationErrors);
