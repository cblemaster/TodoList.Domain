namespace TodoList.Domain.ValueStructs;

internal readonly record struct DateTimeStamps(DateTime CreateDate, DateTime? UpdateDate);
