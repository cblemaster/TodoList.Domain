
namespace TodoList.Domain.DataTransfer;

public class DeleteTodo
{
    public Guid Id { get; set; }
    public bool IsImportant { get; set; }
}
