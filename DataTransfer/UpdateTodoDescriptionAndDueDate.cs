
namespace TodoList.Domain.DataTransfer;

public class UpdateTodoDescriptionAndDueDate
{
    public Guid TodoId { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateOnly? DueDate { get; set; }
}
