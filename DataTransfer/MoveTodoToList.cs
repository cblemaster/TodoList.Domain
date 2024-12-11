
namespace TodoList.Domain.DataTransfer;

public class MoveTodoToList
{
    public Guid TodoId { get; set; }
    public Guid TodoListId { get; set; }
}
