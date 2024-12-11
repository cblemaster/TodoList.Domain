
namespace TodoList.Domain.DataTransfer;

public class DeleteTodoList
{
    public IEnumerable<TodoSummary> Todos { get; set; } = [];
    public Guid Id { get; set; }
}
