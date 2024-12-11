
namespace TodoList.Domain.DataTransfer;

public class DeleteTodo
{
    public bool IsImportant { get; set; }
    public Guid Id { get; set; }
}
