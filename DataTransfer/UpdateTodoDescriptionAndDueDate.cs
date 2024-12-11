
namespace TodoList.Domain.DataTransfer;

public class UpdateTodoDescriptionAndDueDate
{
    public string Description { get; set; } = string.Empty;
    public DateOnly? DueDate { get; set; }
    public Guid TodoId { get; set; }
}
