
namespace TodoList.Domain.DataTransfer;

public class RenameTodoList
{
    public Guid TodoListId { get; set; }
    public string Name { get; set; } = string.Empty;
}
