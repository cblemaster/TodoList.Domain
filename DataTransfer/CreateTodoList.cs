
namespace TodoList.Domain.DataTransfer;

public class CreateTodoList
{
    public string Name { get; set; } = string.Empty;
    public Guid TodoListId { get; set; }
}
