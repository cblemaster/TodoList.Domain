
namespace TodoList.Domain.DataTransfer;

public class TodoListSummary
{
    public string Name { get; set; } = string.Empty;
    public int CountOfTodosNotComplete { get; set; }
    public Guid Id { get; set; }
}
