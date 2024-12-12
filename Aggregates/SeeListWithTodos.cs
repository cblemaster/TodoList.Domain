
using TodoList.Domain.Entities;
using TodoList.Domain.Primitives;
using TodoList.Domain.ValueStructs;

namespace TodoList.Domain.Aggregates;

internal record SeeListWithTodos(TodoListId Id, Descriptor ListName, IEnumerable<Todo> Todos, DateTimeStamps Dates);
