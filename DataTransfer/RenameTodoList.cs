
namespace TodoList.Domain.DataTransfer;

public class RenameTodoList
{
    public string Name { get; set; } = string.Empty;
    public Guid TodoListId { get; set; }
}
