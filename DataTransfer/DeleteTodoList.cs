
namespace TodoList.Domain.DataTransfer;

public class DeleteTodoList
{
    public Guid Id { get; set; }
    public IEnumerable<TodoSummary> Todos { get; set; } = [];
}
