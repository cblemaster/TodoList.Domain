
namespace TodoList.Domain.DataTransfer;

public class TodoListSummary
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int CountOfTodosNotComplete { get; set; }
}
