
namespace TodoList.Domain.DataTransfer;

public class CreateTodoList
{
    public Guid TodoListId { get; set; }
    public string Name { get; set; } = string.Empty;
}
