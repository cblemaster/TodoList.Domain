
namespace TodoList.Domain;

internal record TodoList(TodoListId Id, Descriptor Name, ICollection<Todo> Todos, DateTimeStamps Dates);
